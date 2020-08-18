using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XiangJiGenSui2D : MonoBehaviour {
    public Transform player;
    public int spped = 1;
    public Vector3 camerFw;
    //new Vector3(-0.34f, 2.19f, -1.24f)
    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("player").transform;
	}
	// Update is called once per frame
	void Update () {
        Vector3 weiyizhi = player.position + camerFw ;
        transform.position = Vector3.Lerp(transform.position, weiyizhi, spped * Time.deltaTime);
    }
}
