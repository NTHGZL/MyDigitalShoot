using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot2 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bulletenemy;
    public GameObject bulletenemy1;
    public GameObject bulletenemy2;
    public Vector3 bulletOffset;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnBullet", 1f, 1f);
    }

    private void SpawnBullet()
    {
        Instantiate(bulletenemy, transform.position + bulletOffset, transform.rotation);
        Instantiate(bulletenemy1, transform.position + bulletOffset, transform.rotation);
        Instantiate(bulletenemy2, transform.position + bulletOffset, transform.rotation);
    }
}
