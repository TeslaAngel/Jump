using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D PRigidbody2D;

    public float HorizontalSpeed;
    public float JumpSpeed;
    public float JumpDurationGap;
    private float JumpDuration;
    public AudioClip audio;
    public GameObject playerLight1, playerLight2, playerLight3,globaLight1, globaLight2, globaLight3,yiqun;

   
    private Animator animator;
    public Light2D l2d;
    // Start is called before the first frame update
    void Start()
    {
        
        PRigidbody2D = GetComponent<Rigidbody2D>();
        JumpDuration = 0;
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Horizontal MoveMent
        PRigidbody2D.velocity=(new Vector2(Input.GetAxis("Horizontal")*HorizontalSpeed, PRigidbody2D.velocity.y));

        // Vertical MoveMent(Jump)
        if (Input.GetAxis("Vertical") > 0 && JumpDuration<=0 && PRigidbody2D.velocity.y>=-1f && PRigidbody2D.velocity.y <= 1f)
        {
            PRigidbody2D.velocity = (new Vector2(PRigidbody2D.velocity.x, JumpSpeed));
            JumpDuration = JumpDurationGap;
        }

        if (JumpDuration > 0)
        {
            JumpDuration -= Time.deltaTime;
        }

        // Animator Controller
        if (Input.GetAxis("Horizontal") > 0)
        {
            animator.SetInteger("Speed", 1);
            gameObject.transform.localScale = new Vector2(1,1);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetInteger("Speed", 1);
            gameObject.transform.localScale = new Vector2(-1, 1);
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            animator.SetInteger("Speed", 0);
        }

        if (JumpDuration>0)
        {
            animator.SetBool("JumpTwo",true);
        }
        else
        {
            animator.SetBool("JumpTwo", false);
        }
       
        if (Params.getInstans().getChange1())
        {
            globaLight1.SetActive(false);
            globaLight2.SetActive(true);
            playerLight1.SetActive(false);
            playerLight2.SetActive(true);
            //      proLayrl.volumeLayer();
        }
        if (Params.getInstans().getChange2())
        {
            globaLight1.SetActive(false);
            globaLight2.SetActive(false);  
            globaLight3.SetActive(true);
            playerLight1.SetActive(false);
            playerLight2.SetActive(false);
            playerLight3.SetActive(true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("dead"))
        {
            AudioSource.PlayClipAtPoint(audio, transform.position + Vector3.up, 0.7f);
            
            SceneManager.LoadScene(2);      
        }
        if (collision.gameObject.tag.Equals("change"))
        {
            
            Params.getInstans().setChange1(true);
            collision.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag.Equals("change2"))
        {
            Params.getInstans().setChange2(true);
            collision.gameObject.SetActive(false);
            yiqun.SetActive(false);
           
        }
        if (collision.gameObject.tag.Equals("door"))
        {
            Params.getInstans().setTongguan(true);

        }
    }
}
