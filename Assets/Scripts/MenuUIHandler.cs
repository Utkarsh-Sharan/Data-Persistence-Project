using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text currentPlayerText;
    public TMP_Text bestPlayerText;

    public string _bestPlayer;
    public int _bestScore;

    public void LoadButtonClicked()
    {
        PlayerDataHandler.Instance.LoadNameNScore();
        
        bestPlayerText.text = $"Best Score : {PlayerDataHandler.Instance._bestPlayer} : {PlayerDataHandler.Instance._bestScore}";
    }

    public void StartButtonClicked()
    {
        DisplayCurrentNameInMain();
        SceneManager.LoadScene(1);
    }

    public void QuitButtonClicked()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void DisplayCurrentNameInMain()
    {
        PlayerDataHandler.Instance.playerName = currentPlayerText.text;
    }
}
