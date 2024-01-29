using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar_Enemy : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public Health_Bar health_Bar;
    private StartQuest startQuest;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        health_Bar.SetMaxHealth(maxHealth);
        health_Bar.SetHealth(currentHealth);
        GameObject playerObject = GameObject.FindGameObjectWithTag("QuestSystem");
        startQuest = playerObject.GetComponent<StartQuest>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            TakeDamage(10);
        }*/
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        health_Bar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            if (startQuest.currentQuest.Id == "KO" || (startQuest.currentQuest.Id == "FB"&&gameObject.tag=="Boss"))
            {
                startQuest.IncrementCounter();
                GetComponent<Dissolve>().dissolve();
            }
            else
                GetComponent<Dissolve>().dissolve();
        }
        
    }
}
