using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerRefactors : MonoBehaviour
{
    public void SplittingTimesMinutesSeconds(float _time, float minutes, float seconds)
    {
        minutes = Mathf.FloorToInt(_time / 60);
        seconds = Mathf.FloorToInt(_time % 60);
    }
    
    public float SetMinutes(float _time) => Mathf.FloorToInt(_time / 60);
    public float SetSeconds(float _time) => Mathf.FloorToInt(_time % 60);
}
