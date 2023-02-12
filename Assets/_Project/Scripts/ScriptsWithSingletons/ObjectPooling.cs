using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : Singleton<ObjectPooling>
{
    public List<Arr2D> objectsToPooling;

    // Start is called before the first frame update
    private void Start()
    {
        SetActiveFalseAllObjectInPools();
    }

    public GameObject GetPooledObject(int pooledlist)
    {
        foreach (var pooledObject in objectsToPooling[pooledlist].pooledObjects)
        {
            if (!pooledObject.activeInHierarchy)
            {
                return pooledObject;
            }
        }
        return null;
    }

    public void SetActiveFalseAllObjectInPools()
    {
        foreach (var arr2DList in objectsToPooling)
        {
            if (arr2DList.objectToPool != null)
            {
                for (int i = 0; i < arr2DList.numberObjectToPool; i++)
                {
                    GameObject temp = Instantiate(arr2DList.objectToPool);
                    temp.SetActive(false);
                    arr2DList.pooledObjects.Add(temp);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
