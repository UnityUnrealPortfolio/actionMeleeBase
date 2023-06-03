using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State 
{
    public abstract void Enter();
    public abstract void Tick(float _deltaTime);//Will be passed in from Unity callback
    public abstract void Exit();
}
