using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameplayManager Instance;
    public int scoreInt = 0;
    public TextMeshProUGUI life;
    public TextMeshProUGUI score;
    public GameObject gameOverPanel;
    public int numberOfDiedEnemyForWin = 10;
    public int countOfDiedEnemy = 0;
    public GameObject winPanel;
    public TextMeshProUGUI scoreBeforeLevel2;

    
    private void Awake()
    {
        Instance = this;
        score.text = $"Score : {scoreInt}";
        gameOverPanel.SetActive(false);
        winPanel.SetActive(false);
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (scoreInt <= 0)
        {
            scoreInt = 0;
        }
        if(countOfDiedEnemy >= numberOfDiedEnemyForWin)
        {
            scoreBeforeLevel2.text = $"Your score : {scoreInt}";
            winPanel.SetActive(true);
            
            Time.timeScale = 0;
        }
        score.text = $"Score : {scoreInt}";
    }

    public void Retry()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void ClickMenuBtn()
    {
        SceneManager.LoadScene(0);
    }

    public void ClickNextBtn()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
}
