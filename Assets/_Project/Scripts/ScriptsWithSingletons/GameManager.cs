using System;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public enum GameType
    {
        Arcade,
        Local1VS1,
    }

    public int startPlayerHealth;
    [Range(0.1f,5f)]
    public float gameTime;
    public bool gameOverFlag;
    public bool startTimeFlag;
    public bool allPlayerInGame;
    public GameType _type{set; get; }
    
    public string GameTypeEnumToString()
    {
        return _type.ToString();
    }

    public Action<GameObject> Joined = delegate { };
    public void JoinPlayer(GameObject _gameObject)
    {
        Joined.Invoke(_gameObject);
    }
}
