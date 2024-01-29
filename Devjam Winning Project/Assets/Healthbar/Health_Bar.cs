using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// works for both enemies and player health bar

public class Health_Bar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        // slider.value = health;

        // fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(float health)
    {
        // for enemies
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        if (health <= 0)
        {
            //Destroy(gameObject);
        }
    }
    public void SetPlayerHealth(float health)
    {
        // for player
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}