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
    public TMP_Text playerName;

    private void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonClicked()
    {
        DisplayName();
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

    public void DisplayName()
    {
        PlayerDataHandler.Instance.playerName = playerName.text;
    }
}
