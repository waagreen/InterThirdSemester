//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input/BaseMovement.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @BaseMovement : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @BaseMovement()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""BaseMovement"",
    ""maps"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""id"": ""c8a5f0b0-d8f7-43bc-8bfa-43842210e19a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d6d54af2-977b-482b-8bd3-c182843c3af9"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""bcbe2d4a-29e5-4453-8ad1-4008b442e098"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""e93c59ea-65b0-4d8e-a529-7c4e7ea00f4d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ComfortObject"",
                    ""type"": ""Button"",
                    ""id"": ""33a1d1ec-c9f5-4bc8-86ce-6d6aada50e29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
<<<<<<< HEAD
                    ""name"": ""Tiro"",
                    ""type"": ""Button"",
                    ""id"": ""2aa24725-c96c-4c15-b108-39fe9d991368"",
=======
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""bd3f7701-2787-4588-9c64-bf9f8719a66e"",
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
<<<<<<< HEAD
=======
                },
                {
                    ""name"": ""None"",
                    ""type"": ""Value"",
                    ""id"": ""f2006f42-d045-4ae6-baee-8b97cc3884a6"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""5ef63e56-c595-4c19-b265-a9f549186047"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": ""NormalizeVector3"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""8101cf78-f108-4e03-a119-6e18938e4223"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""19b566f9-7d78-4799-abb7-00f28dcaf107"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""ce5e0f28-217c-464c-afee-ae8b2f4a3060"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""f6d43892-c82c-44d7-987b-4c0be16abf18"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""9731381a-a919-4fe7-87ad-e26c2c87bbe1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Backward"",
                    ""id"": ""217806d9-6674-4b66-ac7a-6f8b3f298b1a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""73adb64d-30f9-453c-b509-a27bf202d94e"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""373c3a61-db40-41e0-9289-6c39317dfad6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3178678-36bf-47b6-a639-ee18a22a28fe"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ComfortObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
<<<<<<< HEAD
                    ""id"": ""0efd7f0d-a038-401a-bb8c-b448cd305023"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Tiro"",
=======
                    ""id"": ""b3a3be74-ead0-4411-b22b-5a59bcd5b818"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2f991fc8-4044-49b4-8c69-736d9548a34e"",
                    ""path"": ""<Sensor>"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""None"",
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Keyboard & Mouse
        m_KeyboardMouse = asset.FindActionMap("Keyboard & Mouse", throwIfNotFound: true);
        m_KeyboardMouse_Movement = m_KeyboardMouse.FindAction("Movement", throwIfNotFound: true);
        m_KeyboardMouse_Run = m_KeyboardMouse.FindAction("Run", throwIfNotFound: true);
        m_KeyboardMouse_Look = m_KeyboardMouse.FindAction("Look", throwIfNotFound: true);
        m_KeyboardMouse_ComfortObject = m_KeyboardMouse.FindAction("ComfortObject", throwIfNotFound: true);
<<<<<<< HEAD
        m_KeyboardMouse_Tiro = m_KeyboardMouse.FindAction("Tiro", throwIfNotFound: true);
=======
        m_KeyboardMouse_PickUp = m_KeyboardMouse.FindAction("PickUp", throwIfNotFound: true);
        m_KeyboardMouse_None = m_KeyboardMouse.FindAction("None", throwIfNotFound: true);
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Keyboard & Mouse
    private readonly InputActionMap m_KeyboardMouse;
    private IKeyboardMouseActions m_KeyboardMouseActionsCallbackInterface;
    private readonly InputAction m_KeyboardMouse_Movement;
    private readonly InputAction m_KeyboardMouse_Run;
    private readonly InputAction m_KeyboardMouse_Look;
    private readonly InputAction m_KeyboardMouse_ComfortObject;
<<<<<<< HEAD
    private readonly InputAction m_KeyboardMouse_Tiro;
=======
    private readonly InputAction m_KeyboardMouse_PickUp;
    private readonly InputAction m_KeyboardMouse_None;
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
    public struct KeyboardMouseActions
    {
        private @BaseMovement m_Wrapper;
        public KeyboardMouseActions(@BaseMovement wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_KeyboardMouse_Movement;
        public InputAction @Run => m_Wrapper.m_KeyboardMouse_Run;
        public InputAction @Look => m_Wrapper.m_KeyboardMouse_Look;
        public InputAction @ComfortObject => m_Wrapper.m_KeyboardMouse_ComfortObject;
<<<<<<< HEAD
        public InputAction @Tiro => m_Wrapper.m_KeyboardMouse_Tiro;
=======
        public InputAction @PickUp => m_Wrapper.m_KeyboardMouse_PickUp;
        public InputAction @None => m_Wrapper.m_KeyboardMouse_None;
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
        public InputActionMap Get() { return m_Wrapper.m_KeyboardMouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardMouseActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardMouseActions instance)
        {
            if (m_Wrapper.m_KeyboardMouseActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnMovement;
                @Run.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnRun;
                @Look.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnLook;
                @ComfortObject.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnComfortObject;
                @ComfortObject.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnComfortObject;
                @ComfortObject.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnComfortObject;
<<<<<<< HEAD
                @Tiro.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTiro;
                @Tiro.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTiro;
                @Tiro.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnTiro;
=======
                @PickUp.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnPickUp;
                @None.started -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnNone;
                @None.performed -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnNone;
                @None.canceled -= m_Wrapper.m_KeyboardMouseActionsCallbackInterface.OnNone;
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
            }
            m_Wrapper.m_KeyboardMouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @ComfortObject.started += instance.OnComfortObject;
                @ComfortObject.performed += instance.OnComfortObject;
                @ComfortObject.canceled += instance.OnComfortObject;
<<<<<<< HEAD
                @Tiro.started += instance.OnTiro;
                @Tiro.performed += instance.OnTiro;
                @Tiro.canceled += instance.OnTiro;
=======
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @None.started += instance.OnNone;
                @None.performed += instance.OnNone;
                @None.canceled += instance.OnNone;
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
            }
        }
    }
    public KeyboardMouseActions @KeyboardMouse => new KeyboardMouseActions(this);
    public interface IKeyboardMouseActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnComfortObject(InputAction.CallbackContext context);
<<<<<<< HEAD
        void OnTiro(InputAction.CallbackContext context);
=======
        void OnPickUp(InputAction.CallbackContext context);
        void OnNone(InputAction.CallbackContext context);
>>>>>>> 99e3685e7fc462cb77a475b702bcd36b55829e65
    }
}
