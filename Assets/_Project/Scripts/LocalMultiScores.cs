using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(LocalMultiScoresUpdater),typeof(LocalMultiScoresDisplayer))]
public class LocalMultiScores : MonoBehaviour
{
    [SerializeField] private LocalMultiManager _manager;
    
    public LocalMultiScoresUpdater _localMultiScoresUpdater;
    public LocalMultiScoresDisplayer _LocalMultiScoresDisplayer;

    private void Start()
    {
        if (_manager == null)
        {
            _manager = GameObject.Find("LocalMultiManager").GetComponent<LocalMultiManager>();
        }

        _localMultiScoresUpdater = GetComponent<LocalMultiScoresUpdater>();
        _LocalMultiScoresDisplayer = GetComponent<LocalMultiScoresDisplayer>();
    }

    private void Update()
    {
        _localMultiScoresUpdater.CheckPlayersDeathToGetScores(_manager);
        _LocalMultiScoresDisplayer.DisplayPoints(_manager);
        _localMultiScoresUpdater.CheckNumbersOfPlayersToStart();
    }
}
