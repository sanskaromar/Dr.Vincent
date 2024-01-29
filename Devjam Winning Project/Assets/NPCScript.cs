using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCScript : MonoBehaviour
{
    public Text text;
    public string speech;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "lpMale_doctor_B")
        {
            text.gameObject.SetActive(true);
            text.text = speech;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "lpMale_doctor_B")
        {
            text.gameObject.SetActive(false);
        }
    }
}
