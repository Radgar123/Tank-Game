using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TimerRefactors),typeof(TimerDisplayOnText))]
public class Timer : MonoBehaviour
{
    [HideInInspector] public bool isTiming;
    
    private  TimerRefactors _timerRefactors;
    private TimerDisplayOnText _timerDisplay;
    
    [SerializeField] private float timeToEndGame;
    [SerializeField] private float minutes;
    [SerializeField] private float seconds;
    // Start is called before the first frame update

    private void Awake()
    {
        _timerRefactors = GetComponent<TimerRefactors>();
        _timerDisplay = GetComponent<TimerDisplayOnText>();
    }

    private void Start()
    {
        EventManager.instance.ResetTime += ResetTimeToGameOver;
        
        ResetTimeToGameOver();
    }

    private void OnDisable()
    {
        EventManager.instance.ResetTime -= ResetTimeToGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        
        CheckTimeToGameOver();
        minutes = _timerRefactors.SetMinutes(timeToEndGame);
        seconds = _timerRefactors.SetSeconds(timeToEndGame);
        //_timerRefactors.SplittingTimesMinutesSeconds(timeToEndGame,minutes,seconds);
        _timerDisplay.DisplayTime(minutes,seconds);
    }

    private void CheckTimeToGameOver()
    {
        if (GameManager.instance.startTimeFlag)
        {
            if (timeToEndGame < 0 && GameManager.instance.startTimeFlag == false)
            {
                GameManager.instance.gameOverFlag = true;
            }
            else
            {
                //GameManager.instance.startTimeFlag = true;
                if (timeToEndGame >= 0)
                {
                    timeToEndGame -= Time.deltaTime;
                }
            
            }
        }
    }
    
    public void ResetTimeToGameOver()
    {
        timeToEndGame = GameManager.instance.gameTime * 60;
        GameManager.instance.startTimeFlag = false;
    }
}
