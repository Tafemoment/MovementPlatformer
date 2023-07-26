using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _playerRB;
    //RB for rigidbody
    bool isJumpInput = false;
    void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Getting input from the keyboard
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpInput = true;
            /*Rigidbody2D playerRB = GetComponent<Rigidbody2D>();

            playerRB.AddForce(Vector2.up * 1200f);*/
            //powercrept code
        }
    }

    void FixedUpdate()
    {
        if (isJumpInput)
        {
            _playerRB.AddForce(Vector2.up * 200f);
            isJumpInput = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerRB.AddForce(Vector2.left * 1200f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerRB.AddForce(Vector2.right * 1200f * Time.deltaTime);
        }
    }
}
