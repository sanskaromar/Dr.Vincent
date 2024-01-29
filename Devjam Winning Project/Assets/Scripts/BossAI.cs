using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossAI : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent thisAgent;
    public Transform player;
    Vector3 moveToPoint;
    [Range(7f,500f)]public float distance;

    
    public float effectradius;
   
    public HealthBar_Ethan playerhealth;
    [Range(0.001f, 1f)] public float covidEffect;
    public GameObject damageLight;
    public Collider[] colliders;
    public bool canBeMoved;
    void Start()
    {
        thisAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(moveToPoint, player.position) > distance&&canBeMoved)
        {
            moveToPoint = player.position;
            thisAgent.destination = moveToPoint;
        }
        CovidDamage();
    }
    void CovidDamage()
    {
        colliders = Physics.OverlapSphere(transform.position, effectradius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Player")
            {
                playerhealth.TakeDamage(covidEffect);
                damageLight.SetActive(true);
               
                
            }
            else
            {
                damageLight.SetActive(false);
            }


        }
    }
}
