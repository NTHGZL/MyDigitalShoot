using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BossManager : MonoBehaviour
{
    public static BossManager Instance;

   
    void Start()
    {
        Instance = this;
       
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHealth.Instance.healthpoint <= 25)
        {
            BossShoot.Instance.repeatRate = 0.5f;
            BossMovement.Instance.speed = 10;
            BossMovement.Instance.posMax = 1;
        }
    }
}
