using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed;
    //public float bounceSpeed;
    float yPos;

    void Start()
    {
        yPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
        
            transform.Rotate(transform.up, rotationSpeed*Time.deltaTime);
        transform.position = new Vector3(transform.position.x, Mathf.Lerp(yPos,yPos+0.2f,Mathf.Abs(Mathf.Sin(Time.time))), transform.position.z);
        
    }
}
