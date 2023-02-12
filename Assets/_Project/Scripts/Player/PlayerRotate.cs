using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRotate : MonoBehaviour, IRotateable
{
    private CharacterController _controller;
    private Vector3 _rotation;

    [SerializeField]
    private float _rotationSpeed;

    public PlayerInput _playerInputController;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _playerInputController = GetComponent<PlayerInput>();
    }

    public void FirstRotateOption(PlayerInputs _playerInputs, float speed)
    {
        /*_controller.transform.Rotate(Vector3.up * _playerInputs.rotatePlayerInput.y * 
                                     (-1) * speed * Time.deltaTime);*/
        _controller.transform.Rotate(Vector3.up * _playerInputs.rotatePlayerInput.x * 
                                      speed * Time.deltaTime);
    }

    public void SecondRotateOption(PlayerInputs _playerInputs, GameObject objToRotate, float speed)
    {
        objToRotate.gameObject.GetComponent<CharacterController>().transform.Rotate(Vector3.up * 
            _playerInputs.rotateTurretInput.x * (1) * speed * Time.deltaTime);
    }
}
