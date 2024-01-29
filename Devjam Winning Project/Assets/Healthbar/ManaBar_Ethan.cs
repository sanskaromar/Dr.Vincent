using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManaBar_Ethan : MonoBehaviour
{

    public float maxMana = 100.0f;
    public float currentMana;
    public float manaDefencePoints; // reduces mana consumption rate
    public Mana_Bar mana_Bar;
    private float nextUpdate = 1.0f; //time from start at which next update will occur
    private float interval = 1.0f; //invterval between updates


    // Start is called before the first frame update
    void Start()
    {
        currentMana = maxMana;
        mana_Bar.SetMaxMana(maxMana);
        manaDefencePoints = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Y))
        // {
        //     PayMana(60.0f);
        // }
        // if (Time.time >= nextUpdate)
        // {
        //     nextUpdate += interval;

        //     // function goes here
        //     if (currentMana < maxMana)
        //     {
        //         IncreaseMana(6.0f);
        //     }
        // }
    }

    public void IncreaseMana(float incManaValue)
    {
        currentMana += incManaValue;
        if (currentMana > maxMana)
        {
            currentMana = maxMana;
        }
        mana_Bar.SetMana(currentMana);
    }
    public void PayMana(float manaCost)
    {
        float remainingMana;
        remainingMana = currentMana - (manaCost / Mathf.Pow((manaDefencePoints), 2.1f));

        if (remainingMana >= 0)
        {
            currentMana = remainingMana;
            mana_Bar.SetMana(currentMana);
        }

    }

    public void IncreaseManaDefencePoints(float incValue)
    {
        manaDefencePoints += incValue;
    }
    public void DecreaseManaDefencePoints(float decValue)
    {
        manaDefencePoints -= decValue;
    }
}
