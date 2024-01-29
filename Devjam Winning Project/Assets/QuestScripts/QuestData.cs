using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data")]
public class QuestData : ScriptableObject
{
    public List<Quest> quests;
}

[System.Serializable]
public class Quest
{
    public string Id;
    public string questInfo;
    public string helpText;
    public Image img;
    // public bool isAccepted;
    public bool isCompleted;
    public int count=0;
    public int target;
    public string reward;
    public int rewardCount;
}