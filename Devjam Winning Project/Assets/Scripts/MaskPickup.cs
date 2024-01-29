using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskPickup : MonoBehaviour
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
            // inc mana by 40
            // inc health defence by 0.008
            healthBar_Ethan.IncreaseDefencePoints(0.008f);
            manaBar.IncreaseMana(25);

        }
    }
}
