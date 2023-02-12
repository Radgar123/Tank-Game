using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(LocalMultiSpawnInPositions))]
public class LocalMultiManager : MonoBehaviour
{
    public List<JoinPlayer> localPlayer; 
    //public PlayerInputManager _manager;
    
    private void Start()
    {
        GameManager.instance.Joined = null;
        GameManager.instance.Joined += SetJoinPlayerLocalVariables;
    }

    private void OnDestroy()
    {
        GameManager.instance.Joined -= SetJoinPlayerLocalVariables;
    }

    private void SetJoinPlayerLocalVariables(GameObject _player)
    {
        for (int i = 0; i < localPlayer.Count; i++)
        {
            if (localPlayer[i].player == null)
            {
                localPlayer[i].player = _player;
                _player.GetComponent<Renderer>().material.color = localPlayer[i].playerColor;
                _player.GetComponent<JooinPlayerToLocalMulti>().id = i;
                _player.transform.name = localPlayer[i]._name;
                break;
            }
        }
    }
}
