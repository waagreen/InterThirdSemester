using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingState : PlayerBaseState
{
    public PlayerMovingState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory) { isRootState = true; }

    public override void EnterState()
    {

    }
    public override void UpdateState() 
    {
        Debug.Log("MOVING");
        CheckSwitchStates();
    }
    public override void ExitState()
    {

    }
    public override void CheckSwitchStates()
    {
        if (Core.Controller.IsMovePressed) ChangeState(_fact.Idle());
    }
    public override void InitializeSubState()
    {
    }

}
