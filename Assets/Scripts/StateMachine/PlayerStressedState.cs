using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStressedState : PlayerBaseState
{
    public PlayerStressedState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory) { isRootState = false; }

    public override void EnterState()
    {
        
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
        if (Core.Controller.IsMovePressed) ChangeState(_fact.Idle());
    }
    public override void InitializeSubState()
    {
    }

}
