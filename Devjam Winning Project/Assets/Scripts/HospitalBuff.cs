using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HospitalBuff : MonoBehaviour
{

    public HealthBar_Ethan healthBar_Ethan;

    void OnTriggerEnter(Collider info)
    {
        if (info.name == "lpMale_doctor_B")
        {
            // hospital will fully heal player if he has less than 20% of health
            // represents that at such worse covid times hospital only take very critical cases
            // at cost of losing some defence
            if (healthBar_Ethan.currentHealth < (0.2f * healthBar_Ethan.maxHealth))
            {
                healthBar_Ethan.IncreaseHealth(healthBar_Ethan.maxHealth);
                healthBar_Ethan.DecreasedefencePoints(0.01f);
            }
            // it will also increase its defence by 0.001 permanently 
            healthBar_Ethan.IncreaseDefencePoints(0.001f);
        }
    }
}
