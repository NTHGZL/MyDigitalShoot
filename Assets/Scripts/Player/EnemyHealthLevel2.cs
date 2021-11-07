using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthLevel2 : MonoBehaviour
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
            if (GameplayLevelTwo.Instance.IsTimeForBonus())
            {
                Instantiate(powerUp, transform.position, transform.rotation);
            }
            
            GameplayLevelTwo.Instance.countOfDiedEnemy++;
            GameplayLevelTwo.Instance.scoreInt += 100;
            
            
          
        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            
           
            Destroy(gameObject);
            GameplayLevelTwo.Instance.countOfDiedEnemy++;

        }
        
        if (other.CompareTag("Bullet"))
        {
            healthpoint--;
            Destroy(other.gameObject);
            
        }
    }
}
