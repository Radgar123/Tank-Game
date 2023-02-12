using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    [HideInInspector] public Vector2 movementInput = Vector2.zero;
    [HideInInspector] public Vector2 rotatePlayerInput = Vector2.zero;
    [HideInInspector] public Vector2 rotateTurretInput = Vector2.zero;
    public bool shooted = false;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
        //Debug.Log(movementInput);
    }

    public void OnPlayerRotate(InputAction.CallbackContext context)
    {
        rotatePlayerInput = context.ReadValue<Vector2>();
    }

    public void OnTurretRotate(InputAction.CallbackContext context)
    {
        rotateTurretInput = context.ReadValue<Vector2>();
    }

    public void OnShoot(InputAction.CallbackContext context)
    {
        //shooted = context.ReadValue<bool>();
        shooted = context.action.triggered;
    }
}
