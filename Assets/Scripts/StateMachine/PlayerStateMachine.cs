using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    CharacterController controller;
<<<<<<< HEAD
    public float moveSpeed = 12f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;

    Vector3 velocity;
=======

    Vector3 moving;

    float movY;
    public float gravity;
    public float speed;
    public float jump;
>>>>>>> 33aa88607f67085f32a66562cec291e7840e15bb

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
<<<<<<< HEAD
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * moveSpeed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


=======
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
>>>>>>> 33aa88607f67085f32a66562cec291e7840e15bb
    }
}
