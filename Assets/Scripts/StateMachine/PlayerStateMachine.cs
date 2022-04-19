using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    private PlayerBaseState _currentState;
    private PlayerStateFactory _states;

    //essential components
    public CharacterController controller;
    public Camera mCam;


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
        Core.Data.stressLevel += Core.Data.stressSpeed / Core.Data.waitTime * Time.deltaTime;
        _currentState.UpdateState();
        Moving();
    }
    public void Moving()
    {
        Core.Data.move = Vector3.zero;
        Core.Data.move = Core.Controller.mInput;
        Core.Data.move = mCam.transform.forward * Core.Data.move.z + mCam.transform.right * Core.Data.move.x;

        controller.Move(Core.Data.move * Core.Data._speed * Time.deltaTime);
    }

    public void Gravity() 
    {
        if (!controller.isGrounded) Core.Data.grav.y += Core.Data._gravity * Time.deltaTime;
        controller.Move(Core.Data.grav * Time.deltaTime);
    }
}
