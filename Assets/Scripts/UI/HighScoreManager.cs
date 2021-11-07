using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public int highScore;
    public const string KEY = "highScore";
    public TextMeshProUGUI highScoreText;
   
    private void Awake()
    {
        highScore = PlayerPrefs.GetInt(KEY, 0);
        highScoreText.text = highScore.ToString();

    }

    public bool IsNewRecord(int score)
    {
        return PlayerPrefs.GetInt(KEY, 0) < score;
    }

    
    
}


