using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartUi : MonoBehaviour
{
    public Animator a;

    private bool switchover;
    private void Awake()
    {
        Screen.fullScreen = false;
    }
    void Update()
    {
      

    }
    public GameObject pInOut,dInOut;
    public void Play() {
    
         SceneManager.LoadScene(1);   
    }
    public void SwithDiff()
    {
        
        dInOut.SetActive(true);
        pInOut.SetActive(false);
    }
    public void Exit() {
        Application.Quit();
    }
    public void Eacy()
    {

        PlayerPrefs.SetString("Diff","jiandan");
  
        dInOut.SetActive(false);
        pInOut.SetActive(true);
    }
    public void Genner()
    {
        PlayerPrefs.SetString("Diff", "yiban");
     
        dInOut.SetActive(false);
        pInOut.SetActive(true);
    }
    public void Jojo()
    {
        PlayerPrefs.SetString("Diff", "jinan");
  
        dInOut.SetActive(false);
        pInOut.SetActive(true);
    }
}
