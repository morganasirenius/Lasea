// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/SeaControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SeaInputControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SeaInputControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SeaControls"",
    ""maps"": [
        {
            ""name"": ""Sea"",
            ""id"": ""2996b32e-8104-4dad-9497-8061678efbd6"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8d877a93-4aa2-410d-801d-65e16b547ab8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VerticalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""da59cadc-886d-45a2-ba5b-84ef98b7b244"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5cc3f48e-265d-44ee-91c4-f9ffb7c25736"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a8f52109-d33a-410b-a5f1-8a37fa059f17"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""eb02ea47-cf39-49c6-8817-7928ec055a34"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f44c4fd6-dc0c-4eec-a676-143e7213ef18"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f52b5d19-2109-46e3-87fd-cee749ff9b32"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""89b45894-7f4d-4a3d-b883-6bc5bc531cc7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""07731377-0623-4f0e-8dce-600165ff9e12"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ab198299-d1f9-42a5-8a8b-b6d7a7892277"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Sea
        m_Sea = asset.FindActionMap("Sea", throwIfNotFound: true);
        m_Sea_HorizontalMove = m_Sea.FindAction("HorizontalMove", throwIfNotFound: true);
        m_Sea_VerticalMove = m_Sea.FindAction("VerticalMove", throwIfNotFound: true);
        m_Sea_Interact = m_Sea.FindAction("Interact", throwIfNotFound: true);
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

    // Sea
    private readonly InputActionMap m_Sea;
    private ISeaActions m_SeaActionsCallbackInterface;
    private readonly InputAction m_Sea_HorizontalMove;
    private readonly InputAction m_Sea_VerticalMove;
    private readonly InputAction m_Sea_Interact;
    public struct SeaActions
    {
        private @SeaInputControls m_Wrapper;
        public SeaActions(@SeaInputControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMove => m_Wrapper.m_Sea_HorizontalMove;
        public InputAction @VerticalMove => m_Wrapper.m_Sea_VerticalMove;
        public InputAction @Interact => m_Wrapper.m_Sea_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Sea; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SeaActions set) { return set.Get(); }
        public void SetCallbacks(ISeaActions instance)
        {
            if (m_Wrapper.m_SeaActionsCallbackInterface != null)
            {
                @HorizontalMove.started -= m_Wrapper.m_SeaActionsCallbackInterface.OnHorizontalMove;
                @HorizontalMove.performed -= m_Wrapper.m_SeaActionsCallbackInterface.OnHorizontalMove;
                @HorizontalMove.canceled -= m_Wrapper.m_SeaActionsCallbackInterface.OnHorizontalMove;
                @VerticalMove.started -= m_Wrapper.m_SeaActionsCallbackInterface.OnVerticalMove;
                @VerticalMove.performed -= m_Wrapper.m_SeaActionsCallbackInterface.OnVerticalMove;
                @VerticalMove.canceled -= m_Wrapper.m_SeaActionsCallbackInterface.OnVerticalMove;
                @Interact.started -= m_Wrapper.m_SeaActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_SeaActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_SeaActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_SeaActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMove.started += instance.OnHorizontalMove;
                @HorizontalMove.performed += instance.OnHorizontalMove;
                @HorizontalMove.canceled += instance.OnHorizontalMove;
                @VerticalMove.started += instance.OnVerticalMove;
                @VerticalMove.performed += instance.OnVerticalMove;
                @VerticalMove.canceled += instance.OnVerticalMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public SeaActions @Sea => new SeaActions(this);
    public interface ISeaActions
    {
        void OnHorizontalMove(InputAction.CallbackContext context);
        void OnVerticalMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
