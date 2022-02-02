﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string SceneToLoad;
    private void OnTriggerEnter(Collider des)
    {
        if (des.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
