using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayLevelTwo : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameplayLevelTwo Instance;
    public int scoreInt; 
    public TextMeshProUGUI life;
    public TextMeshProUGUI score;
    public GameObject gameOverPanel;
    public int numberOfDiedEnemyForWin = 2;
    public int countOfDiedEnemy = 0;
    public GameObject winPanel;
    public TextMeshProUGUI finalScore;
    public GameObject spawnerEnemy;
    public GameObject boss;
    public bool bossIsDead = false;
    public TextMeshProUGUI gameOverScoreText;
    public GameObject newRecordText;
    public GameObject newRecordText2;
    
    private void Awake()
    {
        scoreInt = PlayerPrefs.GetInt("score", 0);
       boss.SetActive(false);
        Instance = this;
        score.text = $"Score : {scoreInt}";
        gameOverPanel.SetActive(false);
        newRecordText.SetActive(false);
        newRecordText2.SetActive(false);
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
        newRecordText2.SetActive(true);
    }
    private void Update()
    {
        if (scoreInt <= 0)
        {
            scoreInt = 0;
        }
        if(countOfDiedEnemy >= numberOfDiedEnemyForWin)
        {
            Destroy(spawnerEnemy);
            if (!bossIsDead)
            {
                boss.SetActive(true);
            }
            
        }
        if(!bossIsDead)
        {
            if (boss.activeSelf)
            {
                if (BossHealth.Instance.healthpoint <= 0)
                {
                    bossIsDead = true;
                    Destroy(boss);
                    Time.timeScale = 0;
                    winPanel.SetActive(true);
                    finalScore.text = "Your score : " + scoreInt.ToString();
                    if (PlayerPrefs.GetInt("highScore", 0) < scoreInt)
                    {
                        IsNewRecord();
                        PlayerPrefs.SetInt("highScore", scoreInt);
                        PlayerPrefs.Save();
                    }
                }

            }
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
                newRecordText2.SetActive(false);
            }
        
    }

    public void ClickMenuBtn()
    {
      
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            if (newRecordText.activeSelf)
            {
                newRecordText.SetActive(false);
                newRecordText2.SetActive(false);
            }
    }

    public void ClickNextBtn()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        if (newRecordText.activeSelf)
        {
            newRecordText.SetActive(false);
            newRecordText2.SetActive(false);
        }
    }
}

