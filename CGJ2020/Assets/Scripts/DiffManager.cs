using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] goArr;
    public Deadline deadline;
    void Awake()
    {
        if (PlayerPrefs.GetString("Diff").Equals("jiandan"))
        {
            deadline.deadSpeed = 0.01f;
            for (int i = 3; i < goArr.Length-1; i++)
            {
                goArr[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("Diff").Equals("yiban"))
        {
            deadline.deadSpeed = 0.018f;
            for (int i = 5; i < goArr.Length - 1; i++)
            {
                goArr[i].SetActive(false);
            }
        }
        else if (PlayerPrefs.GetString("Diff").Equals("jinan"))
        {
            deadline.deadSpeed = 0.03f;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
