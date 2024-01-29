using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CovidDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public float effectradius;
    //public LayerMask notplayer;
    public HealthBar_Ethan playerhealth;
    [Range(0.001f,1f)]public float covidEffect;
   // public GameObject damageLight;
    
    
    public Collider[] colliders;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colliders = Physics.OverlapSphere(transform.position, effectradius);
        foreach(Collider collider in colliders)
        {
            if (collider.tag == "Player")
            {
                playerhealth.TakeDamage(covidEffect);
                
            }
            

        }
    }
   
    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, effectradius);
    }
}
