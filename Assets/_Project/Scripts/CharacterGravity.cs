using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterGravity : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 _gravity;
    private Vector3 _velocity;
    // Start is called before the first frame update
    void Start()
    {
        _gravity = Vector3.down * (float)9.81;
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Gravity();
    }

    private void Gravity()
    {
        //transform.up *= (-1) * 9.81;
        _velocity += _gravity * Time.deltaTime;
        //transform.position += _velocity * Time.deltaTime;
        _characterController.Move(_velocity * Time.deltaTime);
    }
}
