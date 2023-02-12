using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TransformEx
{
    public static void DestroyAllChildren(this Transform Content)
    {
        if (Content.childCount > 0)
        {
            List<GameObject> children = new List<GameObject>(); //For not messing with order
            foreach (Transform child in Content)
            {
                children.Add(child.gameObject);
            }

            Content.DetachChildren();
            foreach (GameObject child in children)
            {
                UnityEngine.Object.DestroyImmediate(child);
            }
        }
    }
}
