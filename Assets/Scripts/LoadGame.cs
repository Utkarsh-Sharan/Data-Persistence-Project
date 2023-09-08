using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class LoadGame : MonoBehaviour
{
    public static LoadGame Instance;
    public TextMeshProUGUI bestPlayerText;

    public string _bestPlayer;
    public int _bestScore;  

    public void SetBestPlayer()
    {
        _bestPlayer = PlayerDataHandler.Instance.bestPlayer;
        _bestScore = PlayerDataHandler.Instance.bestScore;
        bestPlayerText.text = $"Best Score : {_bestPlayer} : {_bestScore}";
    }
}
