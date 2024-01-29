using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartQuest : MonoBehaviour
{
     // Start is called before the first frame update
     public QuestData questData;
     public Text questComplete;
     public Text questInfo;
     public Text questCounter;
     private int questCount;
     public Quest currentQuest;
     public GameObject hospitalAura;
     public Mana_Bar manaBar;
     public GameObject bossSpawner;
     public levelloader lvlloader;
     void Start()
     {
         questCount = 0;
         foreach (Quest quest in questData.quests)
         {
             if (quest.isCompleted)
             {
                 questCount++;
             }
         }
         if(questCount<questData.quests.Count)
         {
             UpdateQuest();
         }
         else
         {
             questInfo.text = "All quests completed";
             questCounter.gameObject.SetActive(false);
         }
     }

     private void UpdateQuest()
     {
         currentQuest = questData.quests[questCount];
         questInfo.text = currentQuest.questInfo;
         currentQuest.count = 0;
         if (currentQuest.Id == "FB")
         {
             questCounter.text = currentQuest.helpText;
             bossSpawner.SetActive(true);
         }
         else if (currentQuest.Id == "TP")
         {
             questCounter.text = currentQuest.helpText;
             hospitalAura.SetActive(true);
         }
         else if (currentQuest.Id != "PH")
         {
             questCounter.text = $"{currentQuest.helpText} : {currentQuest.count}";
             hospitalAura.SetActive(false);
         }
         else
         {
             questCounter.text = currentQuest.helpText;
             hospitalAura.SetActive(true);
         }
    }
     
     IEnumerator CompleteText()
     {
         questComplete.gameObject.SetActive(true);
         questComplete.text = $"Quest completed\nReward : {currentQuest.reward}";
         manaBar.IncreaseMana(currentQuest.rewardCount);
         yield return new WaitForSeconds(2.5f);
         questComplete.gameObject.SetActive(false);
         if (currentQuest.Id == "TP")
         {
             lvlloader.loadlevel(SceneManager.GetActiveScene().buildIndex+1);
         }
     }

     public void CompleteQuest()
     {
         StartCoroutine(CompleteText());
         currentQuest.isCompleted = true;
         questCount++;
         if(questCount<questData.quests.Count)
         {
             UpdateQuest();
         }
         else
         {
             questInfo.text = "All quests completed";
             questCounter.gameObject.SetActive(false);
         }
     }

     public void IncrementCounter()
     {
         currentQuest.count++;
         questCounter.text = $"{currentQuest.helpText} : {currentQuest.count}";
         if (currentQuest.count == currentQuest.target)
         {
             CompleteQuest();
         }
     }
    
}
