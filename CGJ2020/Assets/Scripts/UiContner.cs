using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiContner : MonoBehaviour
{

    public void ok() {
        SceneManager.LoadScene(1);
    }
    public void no() {
        Application.Quit();
    }
    public void quits() {
        SceneManager.LoadScene(0);
    }
}
