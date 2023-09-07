using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class LoadGame : MonoBehaviour
{
    public TextMeshProUGUI bestPlayerText;

    private static string _bestPlayer;
    private static int _bestScore;

    private void Awake()
    {
        LoadNameNScore();
    }

    [System.Serializable]
    public class SaveData
    {
        public string playerName;
        public int score;
    }

    public void LoadNameNScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            Debug.Log("found");
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            _bestPlayer = data.playerName;
            _bestScore = data.score;

            SetBestPlayer();
        }
    }

    void SetBestPlayer()
    {
        bestPlayerText.text = $"Best Score : {_bestPlayer} : {_bestScore}";
    }
}
