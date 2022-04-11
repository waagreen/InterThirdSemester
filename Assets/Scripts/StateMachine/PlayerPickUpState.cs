using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpState : PlayerBaseState
{
    public PlayerPickUpState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory) { isRootState = true; }

    public override void EnterState()
    {

    }
    public override void UpdateState()
    {
        CheckSwitchStates();
        _contex.OnMouseDown();
        _contex.OnMouseUp();
    }
    public override void ExitState()
    {

    }
    public override void CheckSwitchStates()
    {

    }
    public override void InitializeSubState()
    {
    }
}
