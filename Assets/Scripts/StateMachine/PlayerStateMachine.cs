using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateMachine : MonoBehaviour
{
    private PlayerBaseState _currentState;
    private PlayerStateFactory _states;

    public Camera mCam;
    public CharacterController controller;
    public InputHandler inputCallback;

    //variáveis (temporário: MUDAR PRA SCRIPTABLE OBJECT)
    private Vector3 _direction;
    private Vector3 _vision;
    private float _xRot = 0f;
    public float _speed;
    public float _mouseSense;

    //getters setters
    public bool IsMovePressed { get => inputCallback._isMovePressed; }
    public float xRotation { get => _xRot; set { _xRot = value; } }
    public Vector3 Direction { get => _direction; set { _direction = value; } }
    public Vector2 Vision { get => _vision; set { _vision = value; } }

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

    public void FixedUpdate()
    {
        _currentState.UpdateState();
    }

    public void Moving()
    {
        Direction = inputCallback.mInput;
        Direction = mCam.transform.forward * Direction.z + mCam.transform.right * Direction.x;
        controller.Move(Direction * _speed * Time.deltaTime);
    }
    public void LookAround() 
    {
        Vision = inputCallback.mPos;

        xRotation -= Vision.y;
        xRotation = Mathf.Clamp(xRotation, -70f, 70f);

        mCam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        controller.transform.Rotate(Vector3.up * Vision.x);
    }
}
