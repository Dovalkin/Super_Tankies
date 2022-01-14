using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellScript : MonoBehaviour
{
    public GameObject shellParticles;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(shellParticles, transform.position, Quaternion.identity);
        SoundManager.instance.ShellExplosion();

        EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();

        if (enemyHealth != null)
        {
            enemyHealth.TakeHit(1);
        }

        Destroy(gameObject);
        Debug.Log("shell destroyed");
    }
}
