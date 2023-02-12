using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour,IKillable
{
    public float time;
    public void DestroyObject()
    {
        gameObject.SetActive(false);
    }

    public void DestroyObjectByTime()
    {
        Invoke("DisableByTime",time);
    }

    private IEnumerator DisableByTime()
    {
        yield return time;
        DestroyObject();
    }
}
