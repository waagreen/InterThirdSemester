using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private BaseMovement baseMove;

    public Vector3 mPos { get; private set; }
    public Vector3 mInput { get; private set; }
    [HideInInspector] public bool IsMovePressed;

    private void Awake()
    {
        baseMove = new BaseMovement();

        baseMove.KeyboardMouse.ComfortObject.started += PullComfortObject;

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
    public void PullComfortObject(InputAction.CallbackContext context) 
    {
        baseMove.KeyboardMouse.ComfortObject.ReadValueAsButton();
        Core.UI.CreateStressBar(Core.Data.stressLevel); 
        Debug.Log("pressed COMFORT INPUT"); 
    }


    private void OnEnable()
    {
        baseMove.Enable();
    }
    private void OnDisable() 
    {
        baseMove.Disable();
        baseMove.KeyboardMouse.ComfortObject.started -= PullComfortObject;
    }
}
