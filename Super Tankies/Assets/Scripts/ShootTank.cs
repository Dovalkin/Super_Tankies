using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTank : MonoBehaviour
{

    public GameObject bulletSpawnPoint;
    public float waitTime;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet.transform, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
    }
}
