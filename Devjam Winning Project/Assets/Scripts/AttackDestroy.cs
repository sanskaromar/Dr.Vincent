using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDestroy : MonoBehaviour
{
    public GameObject explosion;
    // private void OnTriggerExit(Collider other)
    // {
    //     Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
    //     Destroy(gameObject);
    // }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy")||other.tag=="Boss")
        {
            other.gameObject.GetComponent<HealthBar_Enemy>().TakeDamage(40);
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
