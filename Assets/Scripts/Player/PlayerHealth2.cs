using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth2 : MonoBehaviour
{
    public AudioSource audioSource;
    public int healthpoint = 25;

    public GameObject shield;
    public GameObject boss;
    
    
    void Start()
    {
        GameplayManager.Instance.life.text = $"Life : {healthpoint}";
       
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameplayLevelTwo.Instance.bossIsDead)
        {
            if (boss.activeSelf)
            {
                audioSource.Stop();
            }
        }
       
        
        if (healthpoint <= 0)
        {
            Destroy(gameObject);
            PlayerPrefs.SetInt("score", 0);
            audioSource.Stop();
            Time.timeScale = 0;
            GameplayLevelTwo.Instance.gameOverPanel.SetActive(true);
            GameplayLevelTwo.Instance.gameOverScoreText.text = "Score : " + GameplayManager.Instance.GetScore().ToString();
            if (PlayerPrefs.GetInt("highScore", 0) < GameplayManager.Instance.scoreInt)
            {
                GameplayLevelTwo.Instance.IsNewRecord();
                PlayerPrefs.SetInt("highScore", GameplayLevelTwo.Instance.scoreInt);
                PlayerPrefs.Save();
            }
            
            
         
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            healthpoint--;
            GameplayLevelTwo.Instance.scoreInt -= 50;
            GameplayLevelTwo.Instance.life.text = $"Life : {healthpoint}";
        }
        
        if (other.CompareTag("bulletEnemy"))
        {
            GameplayLevelTwo.Instance.scoreInt -= 25;
           
            healthpoint--;
            GameplayLevelTwo.Instance.life.text = $"Life : {healthpoint}";
            Destroy(other.gameObject);
        }

        if (other.CompareTag("HealthBonus"))
        {
            healthpoint += 1;
            GameplayLevelTwo.Instance.life.text = $"Life : {healthpoint}";
            Destroy(other.gameObject);
        }
        if (other.CompareTag("ScoreBonus"))
        {
            GameplayLevelTwo.Instance.scoreInt += 200;
            GameplayLevelTwo.Instance.score.text = $"Score : {GameplayLevelTwo.Instance.scoreInt}";
            Destroy(other.gameObject);
        }

        if (other.CompareTag("ShieldBonus"))
        {
            shield.SetActive(true);
            Destroy(other.gameObject);
        }
        
        if (other.CompareTag("Ground"))
        {
            GameplayLevelTwo.Instance.gameOverPanel.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
            
        }
    }
}
