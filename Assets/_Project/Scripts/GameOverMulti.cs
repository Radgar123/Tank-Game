using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMulti : MonoBehaviour
{
    [HideInInspector] public bool displayGameOverPanel;

    public GameObject getGameOverPanel;

    private void Start()
    {
        getGameOverPanel = GameObject.FindWithTag("GameOver");
    }

    public void DisplayGameOverPanel()
    {
        if (GameManager.instance.gameOverFlag)
        {
            getGameOverPanel.SetActive(true);
        }
        else
        {
            getGameOverPanel.SetActive(false);
        }
    }
}
