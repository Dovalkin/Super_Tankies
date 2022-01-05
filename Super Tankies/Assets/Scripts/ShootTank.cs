using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootTank : MonoBehaviour
{

    public GameObject bulletSpawnPoint;
    public float waitTime;
    public GameObject bullet;

    public ParticleSystem explosion;
    public Animator recoil;

    // Start is called before the first frame update
    void Start()
    {
        recoil = GetComponent<Animator>();
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
        recoil.SetTrigger("Shoot");
        explosion.Play();
        Instantiate(bullet.transform, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
    }
}
