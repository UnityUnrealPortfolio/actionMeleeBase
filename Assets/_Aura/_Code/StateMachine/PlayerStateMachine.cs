using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    //reference to the Input Reader
    [field: SerializeField]public InputReader m_InputReader{get;private set;}


    private void Start()
    {
        SwitchState(new PlayerTestState(this));
    }
}
