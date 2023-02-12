using UnityEngine;

public interface IRotateable
{
    public void FirstRotateOption(PlayerInputs _playerInputs, float speed);
    public void SecondRotateOption(PlayerInputs _playerInputs,GameObject objToRotate, float speed);
}
