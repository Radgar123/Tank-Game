using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMultiScoresUpdater : MonoBehaviour
{
    public int players = 0, numbersOfDead = 0;
    public JoinPlayer livePlayer;
    
    public void CheckPlayersDeathToGetScores(LocalMultiManager manager)
    {
        players = 0;
        numbersOfDead = 0;
        foreach (var joinPlayer in manager.localPlayer)
        {
            if (joinPlayer.player != null)
            {
                players++;
                if (joinPlayer.player.GetComponent<PlayerHealth>().isDead)
                {
                    numbersOfDead++;
                }
            }
        }
        if (numbersOfDead >= players - 1 && players >= 2 && GameManager.instance.gameOverFlag == false)
        {
            GameManager.instance.gameOverFlag = true;
            AddScore(manager);
        }
    }

    public void CheckNumbersOfPlayersToStart()
    {
        if (players >= 2 && !GameManager.instance.allPlayerInGame)
        {
            GameManager.instance.startTimeFlag = true;
            GameManager.instance.allPlayerInGame = true;
        }
    }

    public void AddScore(LocalMultiManager manager)
    {
        foreach (var joinPlayer in manager.localPlayer)
        {
            if (joinPlayer.player != null)
            {
                if (joinPlayer.player.GetComponent<PlayerHealth>().isDead == false && joinPlayer.player != null)
                {
                    Debug.Log(joinPlayer._name + "Sc");
                    joinPlayer.points++;
                }
            }
        }
    }
    
}
