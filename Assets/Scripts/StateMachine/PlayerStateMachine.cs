using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    private PlayerBaseState _currentState;
    private PlayerStateFactory _states;

    public CharacterController controller;
    public InputHandler inputCallback;
    public Camera mCam;

    //variáveis (temporário: MUDAR PRA SCRIPTABLE OBJECT)
    private float _xRot = 0f;
    public float _gravity = -9.8f;
    public float _speed;
  
    private Vector3 move;
    private Vector3 grav;

    //getters setters
    public bool IsMovePressed { get => inputCallback._isMovePressed; }
    public float xRotation { get => _xRot; set { _xRot = value; } }

    public PlayerBaseState CurrentContext
    {
        get => _currentState;
        set
        {
            _currentState = value;
        }
    }

    //personagem sempre inicia no IDLE STATE
    public void Awake()
    {
        _states = new PlayerStateFactory(this);
        _currentState = _states.Idle();
        _currentState.EnterState();
    }

    public void Update()
    {
        _currentState.UpdateState();
    }

    public void Moving()
    {
        move = Vector3.zero;

        move = inputCallback.mInput;
        move = mCam.transform.forward * move.z + mCam.transform.right * move.x;

        controller.Move(move * _speed * Time.deltaTime);



        if (!controller.isGrounded) grav.y += _gravity * Time.deltaTime;
        controller.Move(grav * Time.deltaTime);
    }
}
