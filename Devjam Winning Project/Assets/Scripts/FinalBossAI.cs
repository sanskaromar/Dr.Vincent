using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FinalBossAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject moveToPoint;
    public GameObject enemyPrefab;
    NavMeshAgent thisAgent;

    public float enemyspawnTime;
    public float enemytimeDiff;

    public float effectspawnTime;
    public float effecttimeDiff;

    public float effectradius;
    public HealthBar_Ethan playerhealth;
    [Range(0.001f, 50f)] public float covidEffect;
    //public GameObject damageLight;
    public Collider[] colliders;
    LinkedList<GameObject> enemies;

    public float incrementsize;
    public float desTime;
    

    void Start()
    {
        thisAgent = GetComponent<NavMeshAgent>();
        enemies = new LinkedList<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        thisAgent.destination = moveToPoint.transform.position;
        BossAttack();
       SpawnEnemies();
        
    }
    void BossAttack()
    {
        if (effectspawnTime <= Time.time)
        {
            playerhealth.TakeDamage(covidEffect);
            effectspawnTime += effecttimeDiff;
            
        }
    }
    void SpawnEnemies()
    {
        if (enemyspawnTime <= Time.time)
        {
            for (int i = 1; i <= 10; i++)
            {
                GameObject enemy= Instantiate(enemyPrefab, new Vector3(Random.Range(-200, 200), 20, Random.Range(-200, 200)), Quaternion.identity);
                enemies.AddLast(enemy);
                GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
                foreach (GameObject playerObject in playerObjects)
                {
                    if (playerObject.GetComponent<HealthBar_Ethan>())
                    {
                        enemy.GetComponent<CovidDamage>().playerhealth = playerObject.GetComponent<HealthBar_Ethan>();
                        break;
                    }
                }

            }
            enemyspawnTime += enemytimeDiff;
        }
        if (desTime <= Time.time)
        {
            for (int i = 1; i <= 10; i++)
            {
                Destroy(GameObject.FindGameObjectsWithTag("Enemy")[i]);
                //Debug.Log("Destroyed");
            }
            desTime += 20;

        }


    }

    
}
