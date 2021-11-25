// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""PlayerHead"",
            ""id"": ""e14e984c-525f-40cc-b703-89d9095f8e9c"",
            ""actions"": [
                {
                    ""name"": ""LeftAction"",
                    ""type"": ""Button"",
                    ""id"": ""28feda17-c316-49ab-b9d3-c64bd854fed6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightAction"",
                    ""type"": ""Button"",
                    ""id"": ""acb84f0a-51db-47c1-94bc-e753e7c0f265"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DownAction"",
                    ""type"": ""Button"",
                    ""id"": ""95144ec5-6a19-42c0-b757-3c5c240d48ed"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpAction"",
                    ""type"": ""Button"",
                    ""id"": ""efe161c9-5f6e-43f7-8332-fcb08d9c1c34"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""41b075bc-f7e2-40e2-8fe5-8e336f6440f5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b832da27-0692-4d80-a2c5-1b84f1ffa0ef"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81afd13c-afd9-4de2-8269-e32f51472cb1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66300cad-560a-4a46-bb0a-23b8db2d78e3"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86a20e56-1c95-48e3-8504-27e399946f81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c531b70-3403-43c3-9fd7-a3b40f8b9d78"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DownAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""308e4215-ef49-406a-bfbc-5f4f41531e54"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e219b648-5e09-4858-9b74-8011b04b22a1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MainMenu"",
            ""id"": ""834b8302-367c-4d41-91e5-612b4fa09f38"",
            ""actions"": [
                {
                    ""name"": ""MenuInteraction"",
                    ""type"": ""Button"",
                    ""id"": ""affea398-8592-4091-80ea-d7a003b1491b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9438fa7c-dd77-4bda-9656-6a444eaa44bd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuInteraction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerHead
        m_PlayerHead = asset.FindActionMap("PlayerHead", throwIfNotFound: true);
        m_PlayerHead_LeftAction = m_PlayerHead.FindAction("LeftAction", throwIfNotFound: true);
        m_PlayerHead_RightAction = m_PlayerHead.FindAction("RightAction", throwIfNotFound: true);
        m_PlayerHead_DownAction = m_PlayerHead.FindAction("DownAction", throwIfNotFound: true);
        m_PlayerHead_UpAction = m_PlayerHead.FindAction("UpAction", throwIfNotFound: true);
        // MainMenu
        m_MainMenu = asset.FindActionMap("MainMenu", throwIfNotFound: true);
        m_MainMenu_MenuInteraction = m_MainMenu.FindAction("MenuInteraction", throwIfNotFound: true);
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

    // PlayerHead
    private readonly InputActionMap m_PlayerHead;
    private IPlayerHeadActions m_PlayerHeadActionsCallbackInterface;
    private readonly InputAction m_PlayerHead_LeftAction;
    private readonly InputAction m_PlayerHead_RightAction;
    private readonly InputAction m_PlayerHead_DownAction;
    private readonly InputAction m_PlayerHead_UpAction;
    public struct PlayerHeadActions
    {
        private @PlayerControlls m_Wrapper;
        public PlayerHeadActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftAction => m_Wrapper.m_PlayerHead_LeftAction;
        public InputAction @RightAction => m_Wrapper.m_PlayerHead_RightAction;
        public InputAction @DownAction => m_Wrapper.m_PlayerHead_DownAction;
        public InputAction @UpAction => m_Wrapper.m_PlayerHead_UpAction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerHead; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerHeadActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerHeadActions instance)
        {
            if (m_Wrapper.m_PlayerHeadActionsCallbackInterface != null)
            {
                @LeftAction.started -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnLeftAction;
                @LeftAction.performed -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnLeftAction;
                @LeftAction.canceled -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnLeftAction;
                @RightAction.started -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnRightAction;
                @RightAction.performed -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnRightAction;
                @RightAction.canceled -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnRightAction;
                @DownAction.started -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnDownAction;
                @DownAction.performed -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnDownAction;
                @DownAction.canceled -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnDownAction;
                @UpAction.started -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnUpAction;
                @UpAction.performed -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnUpAction;
                @UpAction.canceled -= m_Wrapper.m_PlayerHeadActionsCallbackInterface.OnUpAction;
            }
            m_Wrapper.m_PlayerHeadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftAction.started += instance.OnLeftAction;
                @LeftAction.performed += instance.OnLeftAction;
                @LeftAction.canceled += instance.OnLeftAction;
                @RightAction.started += instance.OnRightAction;
                @RightAction.performed += instance.OnRightAction;
                @RightAction.canceled += instance.OnRightAction;
                @DownAction.started += instance.OnDownAction;
                @DownAction.performed += instance.OnDownAction;
                @DownAction.canceled += instance.OnDownAction;
                @UpAction.started += instance.OnUpAction;
                @UpAction.performed += instance.OnUpAction;
                @UpAction.canceled += instance.OnUpAction;
            }
        }
    }
    public PlayerHeadActions @PlayerHead => new PlayerHeadActions(this);

    // MainMenu
    private readonly InputActionMap m_MainMenu;
    private IMainMenuActions m_MainMenuActionsCallbackInterface;
    private readonly InputAction m_MainMenu_MenuInteraction;
    public struct MainMenuActions
    {
        private @PlayerControlls m_Wrapper;
        public MainMenuActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuInteraction => m_Wrapper.m_MainMenu_MenuInteraction;
        public InputActionMap Get() { return m_Wrapper.m_MainMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainMenuActions set) { return set.Get(); }
        public void SetCallbacks(IMainMenuActions instance)
        {
            if (m_Wrapper.m_MainMenuActionsCallbackInterface != null)
            {
                @MenuInteraction.started -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnMenuInteraction;
                @MenuInteraction.performed -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnMenuInteraction;
                @MenuInteraction.canceled -= m_Wrapper.m_MainMenuActionsCallbackInterface.OnMenuInteraction;
            }
            m_Wrapper.m_MainMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MenuInteraction.started += instance.OnMenuInteraction;
                @MenuInteraction.performed += instance.OnMenuInteraction;
                @MenuInteraction.canceled += instance.OnMenuInteraction;
            }
        }
    }
    public MainMenuActions @MainMenu => new MainMenuActions(this);
    public interface IPlayerHeadActions
    {
        void OnLeftAction(InputAction.CallbackContext context);
        void OnRightAction(InputAction.CallbackContext context);
        void OnDownAction(InputAction.CallbackContext context);
        void OnUpAction(InputAction.CallbackContext context);
    }
    public interface IMainMenuActions
    {
        void OnMenuInteraction(InputAction.CallbackContext context);
    }
}
