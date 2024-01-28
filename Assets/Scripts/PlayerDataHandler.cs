using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.IO;

public class PlayerDataHandler : MonoBehaviour
{
    public static PlayerDataHandler Instance;
    public string playerName;
    public int score;

    public string _bestPlayer;
    public int _bestScore;

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

    [System.Serializable]
    public class SaveData
    {
        public string bestPlayerName;
        public int bestPlayerScore;
    }

    public void SaveNameNScore(int bestScore, string bestPlayer)
    {
        SaveData data = new SaveData();
        data.bestPlayerName = bestPlayer;
        data.bestPlayerScore = bestScore;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadNameNScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            //Debug.Log(path);
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            _bestPlayer = data.bestPlayerName;
            _bestScore = data.bestPlayerScore;
        }
    }
}
