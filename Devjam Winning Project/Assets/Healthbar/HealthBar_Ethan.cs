using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar_Ethan : MonoBehaviour
{

    public float maxHealth = 600.0f;
    public float currentHealth;
    public float defencePoints;
    public Health_Bar health_Bar;
    public GameObject gameOverMenu;
    CursorLockMode lockMode;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        health_Bar.SetMaxHealth(maxHealth);
        health_Bar.SetPlayerHealth(currentHealth);
        defencePoints = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(15.0f);
        }*/
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= (damage / Mathf.Pow((defencePoints), 1.5f));
        health_Bar.SetPlayerHealth(currentHealth);
        if (currentHealth <= 0)
        {
            GetComponent<Animator>().SetBool("Dead", true);
            gameOverMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void IncreaseDefencePoints(float incValue)
    {
        defencePoints += incValue;
    }
    public void DecreasedefencePoints(float decValue)
    {
        defencePoints -= decValue;
    }
    public void IncreaseHealth(float inchealthValue)
    {
        currentHealth += inchealthValue;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        health_Bar.SetPlayerHealth(currentHealth);
    }
    public void IncreaseMaxHealth(float incMaxhealthValue)
    {
        maxHealth += incMaxhealthValue;
        health_Bar.SetPlayerHealth(currentHealth);
        health_Bar.SetMaxHealth(maxHealth);

    }
}
