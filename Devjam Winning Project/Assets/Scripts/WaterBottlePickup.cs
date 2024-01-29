using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBottlePickup : MonoBehaviour
{
    // sanitizer
    public Mana_Bar manaBar;
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
            // waterbottle inc 3% of maxhealth
            healthBar_Ethan.IncreaseHealth((healthBar_Ethan.maxHealth) * 0.03f);
            manaBar.IncreaseMana(20);
        }
    }
}
