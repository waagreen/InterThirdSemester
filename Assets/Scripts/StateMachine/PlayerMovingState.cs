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
        CheckSwitchStates();
        _contex.Moving();
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
    }

}
