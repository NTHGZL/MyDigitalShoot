using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int healthpoint = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (healthpoint <= 0)
        {
            Destroy(gameObject);
            Application.Quit();
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
