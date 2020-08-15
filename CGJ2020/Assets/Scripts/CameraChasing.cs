using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChasing : MonoBehaviour
{
    public float Tendency;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tp = transform.position;
        Vector3 lp = Target.position;
        transform.position = Vector3.Lerp(new Vector3(tp.x,tp.y,-10), new Vector3(lp.x, lp.y,-10), Tendency);
    }
}
