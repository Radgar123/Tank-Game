using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour, IMovmentable
{
    private CharacterController _controller;
    private Vector3 playerVelocity;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    public void Movement(PlayerInputs playerInputs,float speed)
    {
        playerVelocity = _controller.transform.forward * playerInputs.movementInput.y;
        _controller.Move(playerVelocity * speed * Time.deltaTime);
    }
}
