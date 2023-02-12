using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameType : MonoBehaviour
{
 public GameManager.GameType gameType;
 
 private void Start()
 {
     GameManager.instance._type = gameType;
 }
}
