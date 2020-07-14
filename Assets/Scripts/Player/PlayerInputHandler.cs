using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public UnityAction PlayerInput;

    public void OnMove(InputAction.CallbackContext context)
    {
        PlayerInput.Invoke();
    }

    public void OnAim(InputAction.CallbackContext context)
    {
        PlayerInput.Invoke();
    }
}
