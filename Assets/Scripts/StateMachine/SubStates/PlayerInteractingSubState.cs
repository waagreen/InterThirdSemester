using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractingSubState : PlayerBaseState
{
    public PlayerInteractingSubState(PlayerStateMachine currentContext, PlayerStateFactory playerStateFactory) : base(currentContext, playerStateFactory, 5) { isRootState = false; }

    public override void EnterState()
    {
        Debug.Log("INTERACTING");
        Core.UI.CreateStressBar(Core.Data.stressLevel);
    }
    public override void UpdateState()
    {
        Core.UI.CheckMiniGameEnd();
        CheckSwitchStates();
    }

    public override void CheckSwitchStates()
    {
        if (Core.Data.isInteracting == false) ChangeState(_fact.Passive());
    }

    public override void ExitState()
    {
        
    }

    public override void InitializeSubState()
    {
        throw new System.NotImplementedException();
    }
}
