using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float speed = 2;

    public float posMax = 4;

    public bool goUp = false;

    public static BossMovement Instance;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goUp)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }else{
            transform.Translate(Vector3.down * speed * Time.deltaTime);
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
