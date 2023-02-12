using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameOverMulti))]
public class GameOver : MonoBehaviour
{
    [HideInInspector] public bool isSingle;

    private GameOverMulti _gameOverMulti;
    
    private void Start()
    {
        CheckGameTypeStatusToGameOver();
        _gameOverMulti = GetComponent<GameOverMulti>();
    }

    private void Update()
    {
        if (!isSingle)
        {
            _gameOverMulti.DisplayGameOverPanel();
        }
    }

    private void CheckGameTypeStatusToGameOver()
    {
        if (GameManager.instance._type == GameManager.GameType.Arcade)
        {
            isSingle = true;
        }
        else
        {
            isSingle = false;
        }
    }
    
}
