using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IKillable
{
    public int _playerHealt;
    public bool isDead;
    
    public void SetPlayerHealth() => _playerHealt = GameManager.instance.startPlayerHealth;

    public void ReducePlayerHealth(int damage)
    {
        _playerHealt -= damage;
    }
        
    public void DestroyObject()
    {
        if (_playerHealt <= 0)
        {
            //Debug.Log("PlayerIsDied");
            isDead = true;
        }
    }
}
