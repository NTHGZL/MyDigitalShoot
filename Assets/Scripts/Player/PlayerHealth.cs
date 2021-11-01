using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public AudioSource audioSource;
    public int healthpoint = 5;

    public GameObject shield;
    
    void Start()
    {
        GameplayManager.Instance.life.text = $"Life : {healthpoint}";
        
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (healthpoint <= 0)
        {
            Destroy(gameObject);
            audioSource.Stop();
            Time.timeScale = 0;
            GameplayManager.Instance.gameOverPanel.SetActive(true);
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            
            healthpoint--;
            GameplayManager.Instance.scoreInt -= 50;
            GameplayManager.Instance.life.text = $"Life : {healthpoint}";
        }
        
        if (other.CompareTag("bulletEnemy"))
        {
            GameplayManager.Instance.scoreInt -= 25;
           
            healthpoint--;
            GameplayManager.Instance.life.text = $"Life : {healthpoint}";
            Destroy(other.gameObject);
        }

        if (other.CompareTag("HealthBonus"))
        {
            healthpoint += 10;
            GameplayManager.Instance.life.text = $"Life : {healthpoint}";
            Destroy(other.gameObject);
        }
        if (other.CompareTag("ScoreBonus"))
        {
            GameplayManager.Instance.scoreInt += 200;
            GameplayManager.Instance.score.text = $"Score : {GameplayManager.Instance.scoreInt}";
            Destroy(other.gameObject);
        }

        if (other.CompareTag("ShieldBonus"))
        {
            shield.SetActive(true);
            Destroy(other.gameObject);
        }
    }

  
}
