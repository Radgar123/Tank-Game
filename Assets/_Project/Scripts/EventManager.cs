using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Singleton<EventManager>
{
    public Action GameOver = delegate {  };
    public Action Restart = delegate {  };
    public Action ResetTime = delegate {  };

    public void EndGame()
    {
        GameOver.Invoke();
    }

    public void RestartGameToNextRound(LocalMultiManager manager)
    {
        Restart.Invoke();
    }

    public void ResetGameTime()
    {
        ResetTime.Invoke();
    }
}
