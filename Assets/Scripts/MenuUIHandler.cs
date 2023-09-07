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
