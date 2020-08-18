using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemViewClick : MonoBehaviour
{
    public Transform first;
 

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {          
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);

            Debug.Log(hit.transform.name);

            Vector3 temp = first.position;
            first.position = hit.transform.position;
            hit.transform.position = temp;
        }
    }
}
