using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int healthpoint = 1;
    
   
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (healthpoint <= 0)
        {
            Destroy(gameObject);
          
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Destroy(gameObject);
          
        }
        
        if (other.CompareTag("Bullet"))
        {
            healthpoint--;
            Destroy(other.gameObject);
        }
    }
}
