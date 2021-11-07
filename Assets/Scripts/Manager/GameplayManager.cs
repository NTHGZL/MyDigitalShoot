using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameplayManager Instance;
    public int scoreInt;
    public TextMeshProUGUI life;
    public TextMeshProUGUI score;
    public GameObject gameOverPanel;
    public int numberOfDiedEnemyForWin = 10;
    public int countOfDiedEnemy = 0;
    public GameObject winPanel;
    public TextMeshProUGUI scoreBeforeLevel2;
    public TextMeshProUGUI gameOverScoreText;
    public GameObject newRecordText;
    
    
    private void Awake()
    {
        
        scoreInt = PlayerPrefs.GetInt("score", 0);
        Instance = this;
        score.text = $"Score : {scoreInt}";
        gameOverPanel.SetActive(false);
        newRecordText.SetActive(false);
        winPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public int GetScore()
    {
        return scoreInt > 0 ? scoreInt : 0;
    }
    public void IsNewRecord()
    {
        newRecordText.SetActive(true);
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

    public bool IsTimeForBonus()
    {
        return countOfDiedEnemy % 3 == 0;
    }
    
    public void Retry()
    {
       
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
            if (newRecordText.activeSelf)
            {
                newRecordText.SetActive(false);
            }
        
    }

    public void ClickMenuBtn()
    {
      
            SceneManager.LoadScene(0);
            if (newRecordText.activeSelf)
            {
                newRecordText.SetActive(false);
            }
    }

    public void ClickNextBtn()
    {
        PlayerPrefs.SetInt("score", scoreInt);
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
        if (newRecordText.activeSelf)
        {
            newRecordText.SetActive(false);
        }
    }
}
