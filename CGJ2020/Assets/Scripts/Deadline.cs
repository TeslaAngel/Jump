using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadline : MonoBehaviour
{
    // Start is called before the first frame update
    public float deadSpeed = 0.0008f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = gameObject.transform.position.y;
        gameObject.transform.position = new Vector2(gameObject.transform.position.x, moveY+ deadSpeed);
    }
}
