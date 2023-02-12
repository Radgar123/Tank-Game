using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.InputSystem;

public class LocalMultiSpawnInPositions : MonoBehaviour
{
    [SerializeField] private PlayerInputManager manager;
    [SerializeField] private LocalMultiManager _localMultiManager;
    [SerializeField] public List<Transform> spawnPoints;
    public int id;

    private void Start()
    {
        SetSpawnPointToPlayer();
        //EventManager.instance.Restart += SpawnAllPlayersInSpawnPoint;
    }

    private void OnDisable()
    {
        //EventManager.instance.Restart -= SpawnAllPlayersInSpawnPoint;
    }

    /*public async Task SetSpawnPositionToPlayer(float duration)
    {
        var end = Time.time + duration;
        while (Time.time < end)
        {
            //manager.playerPrefab.transform.position = spawnPoints[id].position;
            Debug.Log("Test");
            await Task.Yield();
        }
        id++;
    }*/

    public void SetSpawnPointToPlayer()
    {
        manager.playerPrefab.transform.position = spawnPoints[id].position;
        manager.playerPrefab.transform.rotation = spawnPoints[id].rotation;
        id++;
    }

    /*public void SpawnAllPlayersInSpawnPoint()
    {
        for (int i = 0; i < _localMultiManager.localPlayer.Count; i++)
        {
            if (_localMultiManager.localPlayer[i].player != null)
            {
                _localMultiManager.localPlayer[i].player.GetComponent<CharacterController>().enabled = false;
                _localMultiManager.localPlayer[i].player.transform.position = spawnPoints[i].position;
                _localMultiManager.localPlayer[i].player.transform.rotation = spawnPoints[i].rotation;
                _localMultiManager.localPlayer[i].player.GetComponent<CharacterController>().enabled = true;
            }
        }
    }*/
}
