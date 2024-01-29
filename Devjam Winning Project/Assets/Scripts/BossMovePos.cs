using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossMovePos : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject movePoint;
    public float spawnTime;
    public float timeDiff;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (spawnTime <= Time.time)
        {
            movePoint.transform.position = new Vector3(Random.Range(-100, 100), 0, Random.Range(-100, 100));
            Debug.Log("Spawned");
            spawnTime += timeDiff;
        }
    }
   
}
