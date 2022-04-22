using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoldingSubState : PlayerBaseState
{
    public PlayerHoldingSubState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory, 3) { isRootState = false;}

    public override void EnterState()
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState()
    {
        throw new System.NotImplementedException();
    }
    public override void CheckSwitchStates()
    {
        throw new System.NotImplementedException();
    }
    public override void ExitState()
    {
        throw new System.NotImplementedException();
    }

    public override void InitializeSubState()
    {
        throw new System.NotImplementedException();
    }
}
