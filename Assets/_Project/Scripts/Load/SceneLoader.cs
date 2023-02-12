using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private List<string> sceneNamesToLoad;
    
    private void OnEnable()
    {
        LoadScenes();
    }

    private void LoadScenes()
    {
        foreach (var scene in sceneNamesToLoad)
        {
            SceneManager.LoadScene(scene,LoadSceneMode.Additive);
        }
    }
}
