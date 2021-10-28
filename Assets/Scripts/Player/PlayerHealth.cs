using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public AudioSource audioSource;
    public int healthpoint = 5;
    
    
    
    void Start()
    {
        
        
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
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            healthpoint--;
        }
        
        if (other.CompareTag("bulletEnemy"))
        {
            healthpoint--;
            Destroy(other.gameObject);
        }
    }

  
}
