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

    }



    public override void Exit()
    {

    }

    public override void Tick(float _deltaTime)
    {
        //receive movement values each frame from the input reader
        Vector3 moveVector = new Vector3();

        moveVector.x = stateMachine.m_InputReader.m_MoveInput.x;
        moveVector.y = 0;
        moveVector.z = stateMachine.m_InputReader.m_MoveInput.y;

        stateMachine.transform.Translate(moveVector * _deltaTime);
    }
}
