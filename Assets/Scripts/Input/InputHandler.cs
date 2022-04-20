using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private BaseMovement baseMove;

    public Vector2 mPos { get; private set; }
    public Vector3 mInput { get; private set; }
    public bool _isMovePressed { get; private set; }

    private void Awake()
    {
        baseMove = new BaseMovement();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        mInput = context.ReadValue<Vector3>();
        _isMovePressed = mInput != Vector3.zero;
    }

    private void OnEnable() => baseMove.Enable();
    private void OnDisable() => baseMove.Disable();
}
