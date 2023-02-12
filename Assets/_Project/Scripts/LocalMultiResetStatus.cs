using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalMultiResetStatus : MonoBehaviour
{
    [SerializeField] private LocalMultiManager _localMultiManager;
    [SerializeField] private LocalMultiSpawnInPositions spawn;

    public void ResetPointStatus()
    {
        for (int i = 0; i < _localMultiManager.localPlayer.Count; i++)
        {
            if (_localMultiManager.localPlayer[i].player != null)
            {
                _localMultiManager.localPlayer[i].points = 0;
            }
        }
    }
    
    public void SpawnAllPlayersInSpawnPoint()
    {
        for (int i = 0; i < _localMultiManager.localPlayer.Count; i++)
        {
            if (_localMultiManager.localPlayer[i].player != null)
            {
                _localMultiManager.localPlayer[i].player.GetComponent<CharacterController>().enabled = false;
                _localMultiManager.localPlayer[i].player.transform.position = spawn.spawnPoints[i].position;
                _localMultiManager.localPlayer[i].player.transform.rotation = spawn.spawnPoints[i].rotation;
                _localMultiManager.localPlayer[i].player.GetComponent<CharacterController>().enabled = true;
            }
        }
    }

    public void ResetHealthStatus()
    {
        for (int i = 0; i < _localMultiManager.localPlayer.Count; i++)
        {
            if (_localMultiManager.localPlayer[i].player != null)
            {
                _localMultiManager.localPlayer[i].player.GetComponent<PlayerHealth>().isDead = false;
                _localMultiManager.localPlayer[i].player.GetComponent<PlayerHealth>()._playerHealt = 
                    GameManager.instance.startPlayerHealth;
            }
        }
    }

    public void ResetGameOverFlag()
    {
        GameManager.instance.gameOverFlag = false;
    }

    public void ResetTimeStatus()
    {
        EventManager.instance.ResetGameTime();
    }

    public void ResetAllBullets()
    {
        Bullet[] bullets = FindObjectsOfType(typeof(Bullet)) as Bullet[];

        foreach (var bullet in bullets)
        {
            bullet.gameObject.SetActive(false);
        }
    }

    public void ResetTimeStatus(bool isPlay)
    {
        GameManager.instance.startTimeFlag = isPlay;
    }
}
