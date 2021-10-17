using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 5;
    void Update()
    {
        transform.Translate(Vector3.left*speed*Time.deltaTime);
    }

    
}
