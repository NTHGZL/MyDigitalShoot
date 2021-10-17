using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bulletenemy;

    public Vector3 bulletOffset;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("SpawnBullet", 1f, 1f);
    }

    private void SpawnBullet()
    {
        Instantiate(bulletenemy, transform.position + bulletOffset, transform.rotation);
    }
}
