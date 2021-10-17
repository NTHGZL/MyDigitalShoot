using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SpawnerMovement : MonoBehaviour
{
    public float speed = 10;

    public float posMax = 5;

    public bool goUp = false;

    public float time = 0.5f;
    public float repeatRate = 2f;

    public GameObject gameObject;
    public GameObject gameObject1;
    public GameObject gameObject2;

    private GameObject[] spawnObjetcs;
    
    void Start()
    {
        InvokeRepeating("SpawnEnemy", time, repeatRate);
    }

    void SpawnEnemy()
    {
        Instantiate(randomObject(), transform.position, Quaternion.identity);
    }

    private GameObject randomObject()
    {
        int randomInt = (int) Random.Range(0f, 3f);
        if (randomInt == 0)
        {
            return gameObject;
        }else if (randomInt == 1)
        {
            return gameObject1;
        }
        else
        {
            return gameObject2;
        }
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
