using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class GenderWuTi : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] goList;
    public GameObject tr;
    private GameObject go;
    private Vector3 currWz;
    void Start()
    {
        
    }
    private float jiange = 0;
    // Update is called once per frame
    void LateUpdate()
    {
        jiange += Time.deltaTime;
        if (jiange>1)
        {
             currWz = new Vector3(tr.transform.position.x, tr.transform.position.y,0);
             go = Instantiate(goList[Random.Range(0, goList.Length-1)], currWz, Quaternion.identity);
             Destroy(go,5);
             jiange = 0;
        }
       
        
    }
   
}
