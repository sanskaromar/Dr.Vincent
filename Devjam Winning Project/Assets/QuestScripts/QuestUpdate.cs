using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class QuestUpdate : MonoBehaviour
{
    public StartQuest startQuest;
    private Animator m_Animator;

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    public void UpdateQuest()
    {
        if (startQuest.currentQuest.Id == "J20")
        {
            startQuest.IncrementCounter();
        }
        else if (startQuest.currentQuest.Id == "SS5")
        {
            startQuest.IncrementCounter();
        }
    }

    private void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump") && m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Grounded"))
        {
            UpdateQuest();
        }
    }
}
