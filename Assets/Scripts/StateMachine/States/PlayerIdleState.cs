using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState (PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base (currentContext, playerStateFactory, 2) { isRootState = true; }

    public override void EnterState()
    {
        InitializeSubState();
        Debug.Log("IDLE");
    }
    public override void UpdateState()
    {
        CheckSwitchStates();
    }
    public override void ExitState()
    {

    }
    public override void CheckSwitchStates()
    {
        if (_contex.IsMovePressed) ChangeState(_fact.Moving());
    }
    public override void InitializeSubState()
    {
        if (Core.Data.isInteracting) ChangeState(_fact.Interacting());
    }
}
