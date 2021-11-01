using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldHealth : MonoBehaviour
{

    public int health = 10;

    private void Update()
    {
        if (health <= 0)
        {
            gameObject.SetActive(false);
            health = 10;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            health--;
            
            
        }
        
        if (other.CompareTag("bulletEnemy"))
        {
            Destroy(other.gameObject);
            health--;
            
            
        }

    }
}
