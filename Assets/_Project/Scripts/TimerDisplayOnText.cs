using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerDisplayOnText : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Awake()
    {
        timeText = GameObject.Find("GameTimer").transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    public void DisplayTime(float minutes, float seconds)
    {
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
