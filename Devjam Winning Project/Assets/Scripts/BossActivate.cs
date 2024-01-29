using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActivate : MonoBehaviour
{
    public GameObject boss;
    public GameObject bosshealth;
    public GameObject particles;
    private StartQuest questSystem;

    private void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("QuestSystem");
        questSystem = playerObject.GetComponent<StartQuest>();
    }

    // Update is called once per frame
    // void Update()
    // {
    //     // if (questSystem.tag=="FB")
    //     // {
    //     //     questSystem.currentQuest.Id = "FB";
    //     // }
    //     if (boss.GetComponent<HealthBar_Enemy>().currentHealth <= 0)
    //     {
    //         questSystem.CompleteQuest();
    //         gameObject.SetActive(false);
    //     }
    //         
    // }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Activate());
            particles.SetActive(false);
            gameObject.GetComponent<SphereCollider>().enabled = false;
        }
    }
    IEnumerator Activate()
    {
        
            boss.SetActive(true);
            boss.GetComponent<DissolveRev>().dissolveRev();
            bosshealth.SetActive(true);            
            yield return new WaitForSeconds(4f);
            
        if (boss.GetComponent<FinalBossAI>() != null)
        {
            boss.GetComponent<FinalBossAI>().enabled = true;
        }
        else
        {
            boss.GetComponent<BossAI>().enabled = true;
        }
        
    }
}
