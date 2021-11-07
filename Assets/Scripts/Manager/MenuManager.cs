using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public GameObject highScorePanel;

    void Start()
    {
        highScorePanel.SetActive(false);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowHighScore()
    {
        highScorePanel.SetActive(true);
    }
    
    public void ClosePanel()
    {
        highScorePanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
