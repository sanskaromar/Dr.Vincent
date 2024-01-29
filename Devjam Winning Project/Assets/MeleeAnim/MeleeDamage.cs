using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeDamage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] enemies;
    public GameObject enemy;
    [SerializeField] private float attackrange = 5f;
    [SerializeField] private int damage = 10;
    Ray ray;
    bool enemyInAttackRange;
    public LayerMask whatIsPlayer;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyInAttackRange = Physics.CheckSphere(transform.position, attackrange, whatIsPlayer);

        if (enemyInAttackRange && Input.GetMouseButtonDown(1))
        {
            enemy.GetComponent<HealthBar_Enemy>().TakeDamage(10);
            Debug.Log("Hit");
        }
        if (enemy.GetComponent<HealthBar_Enemy>().currentHealth == 0)
        {
            Debug.LogError("DEAD");
        }



    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(ray);
    }
}
