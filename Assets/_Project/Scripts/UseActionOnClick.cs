using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ActionState
{
    Restart,
    Start,
    End
}

public class UseActionOnClick : MonoBehaviour
{
    public ActionState state;
    
    private void CheckState(ActionState _state)
    {
        if (_state == ActionState.Restart)
        {
            GameManager.instance.gameOverFlag = false;
        }
        else if (_state == ActionState.Start)
        {
            //do
        }
        else if (_state == ActionState.End)
        {
            //do   
        }
    }
    
    public void CheckState()
    {
        if (state == ActionState.Restart)
        {
            Debug.Log("Restart");
            GameManager.instance.gameOverFlag = false;
        }
        else if (state == ActionState.Start)
        {
            //do
        }
        else if (state == ActionState.End)
        {
            //do   
        }
    }
}
