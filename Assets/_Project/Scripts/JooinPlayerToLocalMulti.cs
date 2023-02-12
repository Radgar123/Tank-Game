using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JooinPlayerToLocalMulti : MonoBehaviour
{
    public int id;
    
    void Start()
    {
        GameManager.instance.JoinPlayer(gameObject);
    }
}
