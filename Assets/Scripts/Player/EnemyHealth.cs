using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int healthpoint = 1;
    public GameObject powerUp;
    
   
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (healthpoint <= 0)
        {
            
            Destroy(gameObject);
            if (GameplayManager.Instance.IsTimeForBonus())
            {
                Instantiate(powerUp, transform.position, transform.rotation);
            }
            
            GameplayManager.Instance.countOfDiedEnemy++;
            GameplayManager.Instance.scoreInt += 100;
            
            
          
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            
           
            Destroy(gameObject);
            GameplayManager.Instance.countOfDiedEnemy++;

        }
        
        if (other.CompareTag("Bullet"))
        {
            healthpoint--;
            Destroy(other.gameObject);
            
        }
    }
}
