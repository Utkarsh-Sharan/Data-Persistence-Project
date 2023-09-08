using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDataHandler : MonoBehaviour
{
    public static PlayerDataHandler Instance;
    public string playerName;
    public int score;

    public string bestPlayer;
    public int bestScore;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
