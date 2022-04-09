using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void UpdateState(PlayerStateMachine player)
    {
        if(movX != 0 || movZ != 0) player.SwitchState(player.Moving);
    }

    public override void EnterState(PlayerStateMachine playe)
    {
        
    }

    public override void ExitState(PlayerStateMachine playe)
    {
        throw new System.NotImplementedException();
    }
}
