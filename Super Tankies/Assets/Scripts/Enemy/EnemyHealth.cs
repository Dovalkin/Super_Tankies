using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int enemyHealth = 2;
    int healthCounter;

    bool isDestroyed;

    public GameObject enemyTankParticle;

    public GameObject turret;

    private void Awake()
    {
        healthCounter = enemyHealth;
    }
    
    public void TakeHit (int amount)
    {
        if (isDestroyed)
        {
            return;
        }

        healthCounter -= amount;

        if(healthCounter <= 0)
        {
            EnemyDestroyed();
        }

        Debug.Log("enemy tank health" + healthCounter);
    }
    void EnemyDestroyed()
    {
        isDestroyed = true;
        Instantiate(enemyTankParticle, transform.position, Quaternion.identity);

        turret.SetActive(false);
    }
}
