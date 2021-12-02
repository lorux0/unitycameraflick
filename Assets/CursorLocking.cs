using UnityEngine;
using UnityEngine.EventSystems;

public class CursorLocking : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private MouseMovementState mouseMovementState;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        Lock();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Unlock();
    }

    private void Lock()
    {
        Cursor.lockState = CursorLockMode.Locked;
        mouseMovementState.Move = true;
    }

    private void Unlock()
    {
        Cursor.lockState = CursorLockMode.None;
        mouseMovementState.Move = false;
    }
}