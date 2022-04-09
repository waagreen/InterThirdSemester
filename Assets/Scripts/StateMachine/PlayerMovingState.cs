using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovingState : PlayerBaseState
{   
    public override void EnterState(PlayerStateMachine player)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(PlayerStateMachine player) 
    {
        Moving();    
        if(moving == moving.zero) player.SwitchState(player.Idle);
    }


    void Moving()
    {
        moving = Vector3.zero;

        Jump();

        moving = Input.GetAxis("Horizontal") * transform.right * speed * Time.deltaTime;
        moving += Input.GetAxis("Vertical") * transform.forward * speed * Time.deltaTime;
        moving.y = movY * Time.deltaTime;


        controller.Move(moving);
    }

    public override void ExitState(PlayerStateMachine player)
    {
        throw new System.NotImplementedException();
    }
}
