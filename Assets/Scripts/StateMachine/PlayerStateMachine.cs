using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    private CharacterController controller;

    private Vector3 _moving;

    private float movY;
    private float movX = Input.GetAxis("Horizontal");
    private float movZ = Input.GetAxis("Vertical");
    private float gravity;
    private float speed;

    PlayerBaseState currentState;
    public PlayerIdleState Idle = new PlayerIdleState();
    public PlayerMovingState Moving = new PlayerMovingState();

    public void Start() 
    {
        currentState = idle;    
    }

    public void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

}
