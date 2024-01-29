using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

// works for player mana bar

public class Mana_Bar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public GameObject noMana;

    private void Start()
    {
        PlayerPrefs.SetInt("Mana",1);
    }

    public void SetMaxMana(float mana)
    {
        slider.maxValue = mana;
        slider.value = mana;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetMana(float mana)
    {
        slider.value = mana;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void ReduceMana(float mana)
    {
        slider.value -= mana;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        if (slider.value <= 0)
        {
            PlayerPrefs.SetInt("Mana", 0);
            noMana.SetActive(true);
        }
    }

    public void IncreaseMana(float mana)
    {
        slider.value += mana;
        fill.color = gradient.Evaluate(slider.normalizedValue);
        PlayerPrefs.SetInt("Mana",1);
        noMana.SetActive(false);
    }
}