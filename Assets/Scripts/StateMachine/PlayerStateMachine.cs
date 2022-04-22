using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : MonoBehaviour
{
    [HideInInspector] public PlayerBaseState cState;
    [HideInInspector] public PlayerStateFactory fState;

    public CharacterController controller;
    public Camera mCam;

    //getters setters
    public bool IsMovePressed { get => Core.Binds.IsMovePressed; }

    public PlayerBaseState CurrentContext
    {
        get => cState;
        set
        {
            cState = value;
        }
    }

    //personagem sempre inicia no IDLE STATE
    public void Awake()
    {
        Core.Data.stressLevel = 4;
        fState = new PlayerStateFactory(this);
        cState = fState.Idle();
        cState.EnterState();
    }

    public void Update()
    {
        Gravity();
        cState.UpdateStates();
    }

    public void Moving()
    {
        Core.Data.move = Vector3.zero;

        Core.Data.move = Core.Binds.mInput;
        Core.Data.move = mCam.transform.forward * Core.Data.move.z + mCam.transform.right * Core.Data.move.x;

        controller.Move(Core.Data.move * Core.Data._speed * Time.deltaTime);
    }

    public void Gravity() 
    {
        if (controller.isGrounded == false) Core.Data.grav.y += Core.Data._gravity * Time.deltaTime;
        controller.Move(Core.Data.grav * Time.deltaTime);
    }
}
