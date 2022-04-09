using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    CharacterController controller;
    Vector3 movimento;
    float movY;
    public float sensibilidade;
    public float gravidade;
    public float pulo;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        movY = 0;
    }

    // Update is called once per frame
    void Update()
    {
            movimento = Vector3.zero;

            if(controller.isGrounded)
            {
                movY = 0;
                if(Input.GetButtonDown("Jump"))
                {
                    movY += pulo;
                }
            }

            movY -= gravidade;
            
            movimento = transform.right * Input.GetAxis("Horizontal") * sensibilidade * Time.deltaTime;
            movimento += transform.forward * Input.GetAxis("Vertical") * sensibilidade * Time.deltaTime;
            movimento.y = movY  * Time.deltaTime;

            controller.Move(movimento);
    }
}
