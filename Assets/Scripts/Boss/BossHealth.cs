using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{

    public static BossHealth Instance;
    public int healthpoint = 50;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            healthpoint--;
            GameplayLevelTwo.Instance.scoreInt += 100;
            Destroy(other.gameObject);
            
        }
    }
}
