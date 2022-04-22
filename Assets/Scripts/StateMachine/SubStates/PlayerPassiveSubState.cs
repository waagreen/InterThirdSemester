using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPassiveSubState : PlayerBaseState
{
    public PlayerPassiveSubState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory, 4) { isRootState = false; }

    public override void EnterState()
    {
        Debug.Log("PASSIVE");
        Core.Data.isInteracting = false; 
    }
    
    public override void UpdateState()
    {
        CheckSwitchStates();
    }

    public override void CheckSwitchStates()
    {

    }

    public override void ExitState()
    {

    }

    public override void InitializeSubState()
    {

    }

 
}
