using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonPickup : MonoBehaviour
{

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
            // increases max health by 15
            healthBar_Ethan.IncreaseMaxHealth(8);
            healthBar_Ethan.IncreaseHealth((healthBar_Ethan.maxHealth) * 0.02f);
            healthBar_Ethan.IncreaseDefencePoints(0.005f);
            manaBar.IncreaseMana(30);
        }
    }
}
