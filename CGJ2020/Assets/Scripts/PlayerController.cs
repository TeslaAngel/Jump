using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D PRigidbody2D;

    public float HorizontalSpeed;
    public float JumpSpeed;
    public float JumpDurationGap;
    private float JumpDuration;

    private Animator animator;

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
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            animator.SetInteger("Speed", -1);
        }
        if (Input.GetAxis("Horizontal") == 0)
        {
            animator.SetInteger("Speed", 0);
        }

        if (JumpDuration>0)
        {
            animator.SetTrigger("Jump");
        }
        else
        {
            animator.ResetTrigger("Jump");
        }

    }
}
