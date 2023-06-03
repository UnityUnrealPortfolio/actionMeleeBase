using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputReader : MonoBehaviour,PlayerInputMap.IPlayerActionsActions
{
    private PlayerInputMap m_Controls;//cache of a ref to the player input map

    public event Action OnJumpEvent;
    public event Action OnDodgeEvent;
    public Vector2 m_MoveInput { get; private set; }
    private void OnEnable()
    {
        m_Controls = new PlayerInputMap();
        //register this class to listen for callbacks
        m_Controls.PlayerActions.SetCallbacks(this);
        //enable the controls
        m_Controls.Enable();
    }

    private void OnDisable()
    {
        m_Controls.Disable();
    }

    #region Input Interface Implementation
    public void OnJump(InputAction.CallbackContext context)
    {
        //notify all interested listeners when action is performed
        if(context.performed)
        {
            OnJumpEvent?.Invoke();
        }
    }

    public void OnDodge(InputAction.CallbackContext context)
    {
        //notify all interested listeners when action is performed
        if (context.performed)
        {
            OnDodgeEvent?.Invoke();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
       m_MoveInput = context.ReadValue<Vector2>(); 
      
    }
    #endregion
}
