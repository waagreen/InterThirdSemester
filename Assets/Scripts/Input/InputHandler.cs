using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    [HideInInspector] public BaseMovement baseMove;
    [HideInInspector] public bool IsMovePressed;
    public Vector3 mPos { get; private set; }
    public Vector3 mInput { get; private set; }
    public Cinemachine.CinemachineInputProvider mLook;
    public InputActionReference mZero;
    public InputActionReference mFollow;

    private void Awake()
    {
        baseMove = new BaseMovement();

        baseMove.KeyboardMouse.ComfortObject.started += PullComfortObject;
        baseMove.KeyboardMouse.PickUp.started += Interaction;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void OnMoveInput(InputAction.CallbackContext context)
    {
        mInput = baseMove.KeyboardMouse.Movement.ReadValue<Vector3>();
        IsMovePressed = mInput != Vector3.zero;
    }
    public void MouseInput(InputAction.CallbackContext context) 
    {
        mPos = baseMove.KeyboardMouse.Look.ReadValue<Vector2>();

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        Debug.DrawLine(ray.origin, ray.direction * 15f, Color.red);
    }
    public void Interaction(InputAction.CallbackContext context) 
    {
        context.ReadValueAsButton();
    }
    public void PullComfortObject(InputAction.CallbackContext context)
    {
        context.ReadValueAsButton();
        if(Core.Ctx.CurrentContext._stateNum < 5) Core.Data.isComforting = true;
    }


    private void OnEnable()
    {
        baseMove.Enable();
    }
    private void OnDisable()
    {
        baseMove.KeyboardMouse.ComfortObject.started -= PullComfortObject;
        baseMove.Disable();
    }
}
