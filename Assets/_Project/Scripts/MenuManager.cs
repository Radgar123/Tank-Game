using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public List<GameManager.GameType> GameTypes;

    private int temp;

    public void LoadSceneWithGameType(int level)
    {
        temp = level;
        StartCoroutine("LoadAsyncScene");
    }

    IEnumerator LoadAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(GameTypes[temp].ToString());
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
