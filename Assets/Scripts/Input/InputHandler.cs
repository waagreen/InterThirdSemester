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
       
        Core.Data.ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        Debug.DrawLine(Core.Data.ray.origin, Core.Data.ray.direction * 15f, Color.red);
        
        if(Physics.Raycast(Core.Data.ray, out Core.Data.hit,Core.Data.contactDistance) && Core.Data.hit.transform.tag == "PickUp")
        {
            Debug.Log("You can pick this");

        }

    }
    public void Interaction(InputAction.CallbackContext context) 
    {
        context.ReadValueAsButton();

        if (Core.Data.testBool == true)
        {
            Core.Data.isHolding = false;
        }
        if (Physics.Raycast(Core.Data.ray, out Core.Data.hit, Core.Data.contactDistance) && Core.Data.hit.transform.tag == "PickUp")
        {
            Core.Data.isHolding = true;
        }
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
    void toggleRigidBody(bool state, Rigidbody rb)
    {
        rb.useGravity = state;
        rb.isKinematic = !state;
        rb.detectCollisions = state;
    }
        public void PickUpAction()
        {
            Core.Data.testBool = true;
            Debug.Log($"you picked a {Core.Data.hit.transform.name}");
            Core.Data.selectedObject = Core.Data.hit.transform.gameObject;
            toggleRigidBody(false, Core.Data.hit.rigidbody);
            Core.Data.selectedObject.transform.position = Core.Data.playerHands.transform.position;
            Core.Data.selectedObject.transform.SetParent(Core.Data.playerHands.transform);
        
        }

        public void DropAction()
        {
            var pickedRb = Core.Data.selectedObject.GetComponent<Rigidbody>();
            Core.Data.testBool = false;
            Debug.Log($"You dropped a {Core.Data.selectedObject.transform.name}");
            Core.Data.selectedObject.transform.SetParent(null);
            toggleRigidBody(true, pickedRb);
           
        }
}

