using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float speed;
    public bool isMovingRight = true;

    public float leftBoundry;
    public float rightBoundry;
    void Start()
    {
        
    }

    void Update()
    {
        if (isMovingRight)
        {
             transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        }
        else 
        {
            transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
        }

        if (transform.position.x >= 10)
        {
            isMovingRight = false;
        }
        if (transform .position.x <= -10)
        {
            isMovingRight = true;
        }
    }
}
