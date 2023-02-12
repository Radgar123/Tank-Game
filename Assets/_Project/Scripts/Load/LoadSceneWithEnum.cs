using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneWithEnum : MonoBehaviour
{
    public GameManager.GameType _gameType;

    public void LoadSceneWithGameType()
    {
        StartCoroutine("LoadAsyncScene");
    }

    
}
