using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingState : PlayerBaseState
{
    public PlayerMovingState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory, 1) { isRootState = true; }

    public override void EnterState()
    {
        InitializeSubState();
        Debug.Log("MOVING");
    }
    public override void UpdateState() 
    {
        _contex.Moving();
        CheckSwitchStates();
    }
    public override void ExitState()
    {

    }
    public override void CheckSwitchStates()
    {
        if (!_contex.IsMovePressed) ChangeState(_fact.Idle());
    }
    public override void InitializeSubState()
    {
        if (Core.Data.isInteracting) ChangeState(_fact.Interacting());
    }

}
