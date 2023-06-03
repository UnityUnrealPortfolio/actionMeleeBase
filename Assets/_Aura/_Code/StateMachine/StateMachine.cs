using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stores current state we are in
/// has a way to switch between states
/// </summary>
public abstract class StateMachine : MonoBehaviour
{
    //current state
    private State m_CurrentState;

    private void Update()
    {
        /*
         * null conditional operator doesn't work with monobehaviours or scriptable objects 
         */
        m_CurrentState?.Tick(Time.deltaTime); 
    }

    public void SwitchState(State _newState)
    {
        m_CurrentState?.Exit();
        m_CurrentState = _newState;
        m_CurrentState?.Enter();
    }
}
