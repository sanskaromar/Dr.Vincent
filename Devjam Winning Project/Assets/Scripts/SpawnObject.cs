using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject applePrefab;
    public Vector3 center;
    public Vector3 side;

    // Start is called before the first frame update
    void Start()
    {
        SpawnApple();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            SpawnApple();
        }
    }

    public void SpawnApple()
    {
        Vector3 pos = transform.localPosition + center + new Vector3(Random.Range(-side.x / 2, side.x / 2), Random.Range(-side.y / 2, side.y / 2), Random.Range(-side.z / 2, side.z / 2));

        Instantiate(applePrefab, pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 1, 0.6f);
        Gizmos.DrawCube(transform.localPosition + center, side);
    }
}
