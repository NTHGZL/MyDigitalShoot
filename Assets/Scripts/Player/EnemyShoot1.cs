using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bulletenemy;

    public Vector3 bulletOffset;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnBullet", 0.1f, 0.5f);
    }

    private void SpawnBullet()
    {
        Instantiate(bulletenemy, transform.position + bulletOffset, transform.rotation);
    }
}