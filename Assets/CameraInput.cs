using Cinemachine;
using UnityEngine;

public class CameraInput : MonoBehaviour, AxisState.IInputAxisProvider
{
    [SerializeField] private MouseMovementState mouseMovementState;
    
    public float GetAxisValue(int axis)
    {
        if (!mouseMovementState.Move) return 0f;
        if (axis == 0) return Input.GetAxis("Mouse X");
        return Input.GetAxis("Mouse Y");
    }
}