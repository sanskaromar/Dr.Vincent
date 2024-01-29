using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePickup : MonoBehaviour
{

    // need to work on respawn after centain time

    private HealthBar_Ethan healthBar_Ethan;

    private void Start()
    {
        GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject playerObject in playerObjects)
        {
            if (playerObject.GetComponent<HealthBar_Ethan>())
            {
                healthBar_Ethan = playerObject.GetComponent<HealthBar_Ethan>();
                break;
            }
        }
    }

    void OnTriggerEnter(Collider info)
    {
        if (info.name == "lpMale_doctor_B")
        {
            // apple does 5% damage of maxhealth
            // Destroy(gameObject);
            healthBar_Ethan.TakeDamage((healthBar_Ethan.maxHealth) * 0.05f);
            healthBar_Ethan.IncreaseMaxHealth(10);
        }
    }
}
