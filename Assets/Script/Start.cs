using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void Next()
    {
        SceneManager.LoadScene("02_Start");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("01_Tutorial");
    }
    public void Exit()
    {
        Application.Quit();
    }
}