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

    private GameObject selectedObject;
    private GameObject playerHands;

    private void Awake()
    {
        selectedObject = Core.Data.selectedObject;
        playerHands = Core.Data.playerHands;

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

        if (Core.Data.second == 3) Core.Data.isHolding = false;
        if (Physics.Raycast(Core.Data.ray, out Core.Data.hit, 2f * Core.Data.contactDistance) && Core.Data.hit.transform.tag == "PickUp") Core.Data.isHolding = true;
    }
    public void PullComfortObject(InputAction.CallbackContext context)
    {
        context.ReadValueAsButton();
        if(!Core.Data.isComforting) Core.Data.isComforting = true;
    }
    void toggleRigidBody(bool state, Rigidbody rb)
    {
        rb.useGravity = state;
        rb.isKinematic = !state;
        rb.detectCollisions = state;
        rb.drag = 0;
    }
    public void PickUpAction()
    {
        Debug.Log($"you picked a {Core.Data.hit.transform.name}");
        selectedObject = Core.Data.hit.transform.gameObject;
        toggleRigidBody(false, Core.Data.hit.rigidbody);
        selectedObject.transform.position = playerHands.transform.position;
        selectedObject.transform.SetParent(playerHands.transform);
    }
    public void DropAction()
    {
        var pickedRb = selectedObject.GetComponent<Rigidbody>();
        Debug.Log($"You dropped a {selectedObject.transform.name}");
        selectedObject.transform.SetParent(null);
        toggleRigidBody(true, pickedRb);
        pickedRb.AddForce(playerHands.transform.forward * 5f, ForceMode.Impulse);
        pickedRb.drag = 0.5f;
    }
    
    private void OnEnable() => baseMove.Enable();
    
    private void OnDisable()
    {
        baseMove.KeyboardMouse.ComfortObject.started -= PullComfortObject;
        baseMove.KeyboardMouse.PickUp.started -= Interaction;
        baseMove.Disable();
    }
}

