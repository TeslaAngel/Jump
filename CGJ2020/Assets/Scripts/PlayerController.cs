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

    // Start is called before the first frame update
    void Start()
    {
        PRigidbody2D = GetComponent<Rigidbody2D>();
        JumpDuration = 0;
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


    }
}
