using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoldingSubState : PlayerBaseState
{
    public PlayerHoldingSubState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory, 3) { isRootState = false;}

    public override void EnterState()
    {
    }

    public override void UpdateState()
    {

    }
    public override void CheckSwitchStates()
    {
        if (Core.Data.isComforting == false && Core.Data.isHolding == false) ChangeState(_fact.Passive());
    }
    public override void ExitState()
    {
    }

    public override void InitializeSubState()
    {
        
    }
}
