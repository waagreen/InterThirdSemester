using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public PlayerIdleState (PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base (currentContext, playerStateFactory) { isRootState = true; }

    public override void EnterState()
    {
        Debug.Log("IDLE");
        _contex.Direction = Vector3.zero;
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
    }
}
