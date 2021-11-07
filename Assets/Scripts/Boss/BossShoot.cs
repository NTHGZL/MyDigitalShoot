using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{

    public GameObject bossBullet;
    public GameObject fastBossBullet;

    public Vector3 bulletOffset;
    public static BossShoot Instance; 
    public int count = 0;
    public float repeatRate = 1f;
    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", 1f, repeatRate);
    }

    public void SpawnBullet()
    {
        count++;
        if (count % 5 ==  0)
        {
            Instantiate(fastBossBullet, transform.position + bulletOffset, transform.rotation);
        }
        else
        {
            Instantiate(bossBullet, transform.position + bulletOffset, transform.rotation);
        }
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
