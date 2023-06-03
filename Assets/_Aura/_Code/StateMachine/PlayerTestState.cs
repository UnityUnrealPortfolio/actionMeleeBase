using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestState : PlayerBaseState
{
    private float maxTime = 5f;
    public PlayerTestState(PlayerStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        Debug.Log("Entering Test State");  
    }

    public override void Exit()
    {
        Debug.Log("Exiting Test State");
    }

    public override void Tick(float _deltaTime)
    {
        Debug.Log("Starting Timer: ");
        Debug.Log(Mathf.Round(maxTime -= Time.deltaTime));
        if(maxTime < Mathf.Epsilon)
        {
            stateMachine.SwitchState(new PlayerTestState(stateMachine));
         
        }
    }
}
