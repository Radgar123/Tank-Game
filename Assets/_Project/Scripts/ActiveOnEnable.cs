using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public enum IsActive
{
    Yes,
    No
}

public class ActiveOnEnable : MonoBehaviour
{
    public IsActive activeObjectt;
    
    private void OnEnable()
    {
        ActiveDeactiveObject();
    }

    [ContextMenu("ActiveDisActive")]
    private void ActiveDeactiveObject()
    {
        if (activeObjectt == IsActive.No)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
    }
}
