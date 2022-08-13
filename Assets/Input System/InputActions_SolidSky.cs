//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.1
//     from Assets/Input System/InputActions_SolidSky.inputactions
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

public partial class @InputActions_SolidSky : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions_SolidSky()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions_SolidSky"",
    ""maps"": [
        {
            ""name"": ""PlayerHoverSmall"",
            ""id"": ""f73b4955-0a20-466c-a696-8d3b41850392"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""4f33ff05-c49c-4206-a2d1-0ce1bd3e95db"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""a1db0b1a-3d2e-4422-8e83-1a709121936f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""b02cfbbc-8bf0-40de-93ff-c8ba495194c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""738517a6-3ba1-42ba-85aa-5b8457cdee7f"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""4cc8891c-461a-474c-ab69-c70c643b9a21"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""c583f10f-de56-49ac-bcde-498615c16f87"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""c4eabbd6-0993-40a1-85cf-675c026926f8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""44cfcf88-9098-4f06-9be9-fc38653c79a7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""32e4b574-ce22-4d37-bd26-fa33c77c988a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1e83528c-5dc4-43c9-98c5-53b10ebb760f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse_Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""540bbc2a-f70d-4056-a528-9571db3761d9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse_Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""261b7a1c-654e-495b-846c-b2d34cb6876d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse_Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f82b225d-3c62-4593-b60b-595397c9665c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse_Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""75b15e5e-3f53-4438-a678-896ce8e78787"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""611bf6e5-8171-44a1-94c7-875b693bf107"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse_Keyboard"",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""RightStick"",
                    ""id"": ""264f2a3b-32d4-44b9-bada-5df89c82e08a"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8b9a4ffb-4518-48ee-87eb-301f34653b0d"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""dec33930-a526-4daf-9c22-c43fb8cc5137"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a7dc2e9c-867f-47ba-8b9f-6a5fb5df3f8c"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5e79ee6a-0f6f-4288-8729-03b5d9aec189"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad_Generic"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a0b12dd1-9b4c-4590-8e7b-27d12c232ea2"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse_Keyboard"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse_Keyboard"",
            ""bindingGroup"": ""Mouse_Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad_Generic"",
            ""bindingGroup"": ""Gamepad_Generic"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerHoverSmall
        m_PlayerHoverSmall = asset.FindActionMap("PlayerHoverSmall", throwIfNotFound: true);
        m_PlayerHoverSmall_Movement = m_PlayerHoverSmall.FindAction("Movement", throwIfNotFound: true);
        m_PlayerHoverSmall_Boost = m_PlayerHoverSmall.FindAction("Boost", throwIfNotFound: true);
        m_PlayerHoverSmall_Camera = m_PlayerHoverSmall.FindAction("Camera", throwIfNotFound: true);
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

    // PlayerHoverSmall
    private readonly InputActionMap m_PlayerHoverSmall;
    private IPlayerHoverSmallActions m_PlayerHoverSmallActionsCallbackInterface;
    private readonly InputAction m_PlayerHoverSmall_Movement;
    private readonly InputAction m_PlayerHoverSmall_Boost;
    private readonly InputAction m_PlayerHoverSmall_Camera;
    public struct PlayerHoverSmallActions
    {
        private @InputActions_SolidSky m_Wrapper;
        public PlayerHoverSmallActions(@InputActions_SolidSky wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerHoverSmall_Movement;
        public InputAction @Boost => m_Wrapper.m_PlayerHoverSmall_Boost;
        public InputAction @Camera => m_Wrapper.m_PlayerHoverSmall_Camera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerHoverSmall; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerHoverSmallActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerHoverSmallActions instance)
        {
            if (m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnMovement;
                @Boost.started -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnBoost;
                @Camera.started -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_PlayerHoverSmallActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public PlayerHoverSmallActions @PlayerHoverSmall => new PlayerHoverSmallActions(this);
    private int m_Mouse_KeyboardSchemeIndex = -1;
    public InputControlScheme Mouse_KeyboardScheme
    {
        get
        {
            if (m_Mouse_KeyboardSchemeIndex == -1) m_Mouse_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse_Keyboard");
            return asset.controlSchemes[m_Mouse_KeyboardSchemeIndex];
        }
    }
    private int m_Gamepad_GenericSchemeIndex = -1;
    public InputControlScheme Gamepad_GenericScheme
    {
        get
        {
            if (m_Gamepad_GenericSchemeIndex == -1) m_Gamepad_GenericSchemeIndex = asset.FindControlSchemeIndex("Gamepad_Generic");
            return asset.controlSchemes[m_Gamepad_GenericSchemeIndex];
        }
    }
    public interface IPlayerHoverSmallActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
}