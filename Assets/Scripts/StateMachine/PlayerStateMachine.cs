using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    CharacterController controller;

    Vector3 moving;

    float movY;
    public float gravity;
    public float speed;
    public float jump;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    void Moving()
    {
        moving = Vector3.zero;

        Jump();

        moving = Input.GetAxis("Horizontal") * transform.right * speed * Time.deltaTime;
        moving += Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        moving.y = movY * Time.deltaTime;


        controller.Move(moving);


    }

    void Jump()
    {
        if (controller.isGrounded)
        {
            movY = 0;
            if (Input.GetButtonDown("Jump")) { movY += jump; }
        }

        movY -= gravity;
    }
}
