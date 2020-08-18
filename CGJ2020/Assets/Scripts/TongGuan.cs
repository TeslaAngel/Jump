using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TongGuan : MonoBehaviour
{
    public Animator a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Params.getInstans().getTongguan())
        {
            a.SetTrigger("open");
            SceneManager.LoadScene(2);

            Params.getInstans().setTongguan(false);
        }
    }
}
