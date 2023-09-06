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
    public TMP_Text bestPlayerText;
    private static string _bestPlayer;
    private static int _bestScore;

    private void Awake()
    {
        LoadNameNScoreInMenu();
    }

    public void StartButtonClicked()
    {
        DisplayNameInMain();
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

    public void DisplayNameInMain()
    {
        PlayerDataHandler.Instance.playerName = bestPlayerText.text;
    }

    public class SaveDataInMenu
    {
        public string playerName;
        public int score;
    }

    void LoadNameNScoreInMenu()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveDataInMenu data = JsonUtility.FromJson<SaveDataInMenu>(json);

            _bestPlayer = data.playerName; 
            _bestScore = data.score;

            SetBestPlayer();
        }
    }

    void SetBestPlayer()        //TODO: Check this for main menu name n score
    {
        if (_bestPlayer != null && _bestScore != 0)
        {
            bestPlayerText.text = $"Best Score : {_bestPlayer} : {_bestScore}";
        }
        else
        {
            bestPlayerText.text = "";
        }
    }
}
