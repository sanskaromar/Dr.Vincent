using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTouchDissolve : MonoBehaviour
{
    private StartQuest startQuest;

    private void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("QuestSystem");
        startQuest = playerObject.GetComponent<StartQuest>();
    }
    // replaced Collider other with Collider info and used if statement
    // if something is fucked up due to that, change it back :)
    private void OnTriggerEnter(Collider info)
    {
        if (info.name == "lpMale_doctor_B")
        {
            if (gameObject.CompareTag("OC"))
            {
                if (startQuest.currentQuest.Id == "OC")
                {
                    startQuest.IncrementCounter();
                    GetComponent<Dissolve>().dissolve();
                }
            }
            else if (gameObject.CompareTag("PH"))
            {
                if (startQuest.currentQuest.Id == "PH" || startQuest.currentQuest.Id == "TP")
                {
                    startQuest.IncrementCounter();
                    GetComponent<Dissolve>().dissolve();
                }
            }
            else
            {
                GetComponent<Dissolve>().dissolve();
            }
        }
    }
}
