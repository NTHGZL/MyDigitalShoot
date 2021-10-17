using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement1 : MonoBehaviour
{
    public float speed = 5;

    public bool goUp;

    private int posMax = 4;

    

    void Update()
    {
        
            
        if (goUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime + Vector3.left * speed * Time.deltaTime);
        }else{
            transform.Translate(Vector3.down * speed * Time.deltaTime + Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.y >= posMax)
        {
            goUp = false;
        }
        else if (transform.position.y <= -posMax)
        {
            goUp = true;
        }
            
        
      
        
    }

    
}