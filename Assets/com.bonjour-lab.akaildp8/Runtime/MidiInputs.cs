// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/AKAIController/MidiInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Bonjour
{
    public class @MidiInputs : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @MidiInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""MidiInputs"",
    ""maps"": [
        {
            ""name"": ""MidiControls"",
            ""id"": ""bea38d04-0d50-43c6-8db8-46185eeda183"",
            ""actions"": [
                {
                    ""name"": ""PAD1"",
                    ""type"": ""Button"",
                    ""id"": ""ecf783c1-60f7-4b38-805a-d06eabadf1db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PAD2"",
                    ""type"": ""Button"",
                    ""id"": ""61722f1d-3683-448d-8dfb-7393c51e51f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PAD3"",
                    ""type"": ""Button"",
                    ""id"": ""b419d933-3cac-4fe2-a054-115e2917f1e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PAD4"",
                    ""type"": ""Button"",
                    ""id"": ""cd34f314-cae7-40ff-83e1-95dccf90ce65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PAD5"",
                    ""type"": ""Button"",
                    ""id"": ""57a34fa7-e9e2-43fe-bf03-3c1fbd793dc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PAD6"",
                    ""type"": ""Button"",
                    ""id"": ""385444bd-968f-4047-baf2-188166696ff9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PAD7"",
                    ""type"": ""Button"",
                    ""id"": ""a2cac516-7b86-41ae-803e-0e032ade816e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PAD8"",
                    ""type"": ""Button"",
                    ""id"": ""2ad53c5c-59a9-40d6-98f9-720195a7dfad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB1"",
                    ""type"": ""Value"",
                    ""id"": ""16adc8a5-51e1-4d33-9c9a-7dc7970ccd0d"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB2"",
                    ""type"": ""Value"",
                    ""id"": ""2035bb5a-e100-478d-8207-a275c3283315"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB3"",
                    ""type"": ""Value"",
                    ""id"": ""cc52069c-3e78-412e-95de-5f5fbdfc6453"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB4"",
                    ""type"": ""Value"",
                    ""id"": ""a279def6-73ca-455d-86a1-5d85b6232b64"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB5"",
                    ""type"": ""Value"",
                    ""id"": ""ebe104f3-8f89-4ae1-b433-aa82af70bfcc"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB6"",
                    ""type"": ""Value"",
                    ""id"": ""7477c82b-ecf6-4364-8ebe-1eba36af245d"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB7"",
                    ""type"": ""Value"",
                    ""id"": ""e991ddea-bcc2-4165-9166-c0dfa35d6bd6"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""KNOB8"",
                    ""type"": ""Value"",
                    ""id"": ""a08582c4-dfee-441a-bca3-bb94e769ac2c"",
                    ""expectedControlType"": ""MidiValue"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""31f89d16-f4e9-4e9b-96b6-90275a2ba468"",
                    ""path"": ""<MidiDevice>/note001"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4f14df5-073c-422b-a968-7c7406a1e3ea"",
                    ""path"": ""<MidiDevice>/control001"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e76b428f-6402-49b3-b752-a88937fa2af5"",
                    ""path"": ""<MidiDevice>/note002"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""add6a958-d198-4eb5-97e6-9d41b94506f4"",
                    ""path"": ""<MidiDevice>/note003"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45b4fc26-3d4b-4fdc-a77f-d4b7a7b1c587"",
                    ""path"": ""<MidiDevice>/note004"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74528f02-4e2d-48ad-85e7-0fa3ac56310d"",
                    ""path"": ""<MidiDevice>/note005"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfdc3e6b-f28c-4fbd-9bee-192862dd0db4"",
                    ""path"": ""<MidiDevice>/note006"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1afd23f-f5f5-4a83-884f-da645afbf79c"",
                    ""path"": ""<MidiDevice>/note007"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60c0c1d8-8c32-46ae-971d-7198172ec96a"",
                    ""path"": ""<MidiDevice>/note008"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PAD8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae57c7e7-0904-471e-b361-9229ed16d7e2"",
                    ""path"": ""<MidiDevice>/control002"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90f6c367-fbe1-4af8-afdc-23c53c115737"",
                    ""path"": ""<MidiDevice>/control003"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ab86956-59a6-43fb-b2f1-621b178050cb"",
                    ""path"": ""<MidiDevice>/control004"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b0edd57-44a2-4bc5-8d01-7fc3e19f63e8"",
                    ""path"": ""<MidiDevice>/control005"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5407a417-132f-439a-b76f-1385940957df"",
                    ""path"": ""<MidiDevice>/control006"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""886490c1-a70b-4bcf-be72-722491db8b41"",
                    ""path"": ""<MidiDevice>/control007"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b9d730a-baf5-4372-b1b7-4d25b48fec1b"",
                    ""path"": ""<MidiDevice>/control008"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""KNOB8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // MidiControls
            m_MidiControls = asset.FindActionMap("MidiControls", throwIfNotFound: true);
            m_MidiControls_PAD1 = m_MidiControls.FindAction("PAD1", throwIfNotFound: true);
            m_MidiControls_PAD2 = m_MidiControls.FindAction("PAD2", throwIfNotFound: true);
            m_MidiControls_PAD3 = m_MidiControls.FindAction("PAD3", throwIfNotFound: true);
            m_MidiControls_PAD4 = m_MidiControls.FindAction("PAD4", throwIfNotFound: true);
            m_MidiControls_PAD5 = m_MidiControls.FindAction("PAD5", throwIfNotFound: true);
            m_MidiControls_PAD6 = m_MidiControls.FindAction("PAD6", throwIfNotFound: true);
            m_MidiControls_PAD7 = m_MidiControls.FindAction("PAD7", throwIfNotFound: true);
            m_MidiControls_PAD8 = m_MidiControls.FindAction("PAD8", throwIfNotFound: true);
            m_MidiControls_KNOB1 = m_MidiControls.FindAction("KNOB1", throwIfNotFound: true);
            m_MidiControls_KNOB2 = m_MidiControls.FindAction("KNOB2", throwIfNotFound: true);
            m_MidiControls_KNOB3 = m_MidiControls.FindAction("KNOB3", throwIfNotFound: true);
            m_MidiControls_KNOB4 = m_MidiControls.FindAction("KNOB4", throwIfNotFound: true);
            m_MidiControls_KNOB5 = m_MidiControls.FindAction("KNOB5", throwIfNotFound: true);
            m_MidiControls_KNOB6 = m_MidiControls.FindAction("KNOB6", throwIfNotFound: true);
            m_MidiControls_KNOB7 = m_MidiControls.FindAction("KNOB7", throwIfNotFound: true);
            m_MidiControls_KNOB8 = m_MidiControls.FindAction("KNOB8", throwIfNotFound: true);
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

        // MidiControls
        private readonly InputActionMap m_MidiControls;
        private IMidiControlsActions m_MidiControlsActionsCallbackInterface;
        private readonly InputAction m_MidiControls_PAD1;
        private readonly InputAction m_MidiControls_PAD2;
        private readonly InputAction m_MidiControls_PAD3;
        private readonly InputAction m_MidiControls_PAD4;
        private readonly InputAction m_MidiControls_PAD5;
        private readonly InputAction m_MidiControls_PAD6;
        private readonly InputAction m_MidiControls_PAD7;
        private readonly InputAction m_MidiControls_PAD8;
        private readonly InputAction m_MidiControls_KNOB1;
        private readonly InputAction m_MidiControls_KNOB2;
        private readonly InputAction m_MidiControls_KNOB3;
        private readonly InputAction m_MidiControls_KNOB4;
        private readonly InputAction m_MidiControls_KNOB5;
        private readonly InputAction m_MidiControls_KNOB6;
        private readonly InputAction m_MidiControls_KNOB7;
        private readonly InputAction m_MidiControls_KNOB8;
        public struct MidiControlsActions
        {
            private @MidiInputs m_Wrapper;
            public MidiControlsActions(@MidiInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @PAD1 => m_Wrapper.m_MidiControls_PAD1;
            public InputAction @PAD2 => m_Wrapper.m_MidiControls_PAD2;
            public InputAction @PAD3 => m_Wrapper.m_MidiControls_PAD3;
            public InputAction @PAD4 => m_Wrapper.m_MidiControls_PAD4;
            public InputAction @PAD5 => m_Wrapper.m_MidiControls_PAD5;
            public InputAction @PAD6 => m_Wrapper.m_MidiControls_PAD6;
            public InputAction @PAD7 => m_Wrapper.m_MidiControls_PAD7;
            public InputAction @PAD8 => m_Wrapper.m_MidiControls_PAD8;
            public InputAction @KNOB1 => m_Wrapper.m_MidiControls_KNOB1;
            public InputAction @KNOB2 => m_Wrapper.m_MidiControls_KNOB2;
            public InputAction @KNOB3 => m_Wrapper.m_MidiControls_KNOB3;
            public InputAction @KNOB4 => m_Wrapper.m_MidiControls_KNOB4;
            public InputAction @KNOB5 => m_Wrapper.m_MidiControls_KNOB5;
            public InputAction @KNOB6 => m_Wrapper.m_MidiControls_KNOB6;
            public InputAction @KNOB7 => m_Wrapper.m_MidiControls_KNOB7;
            public InputAction @KNOB8 => m_Wrapper.m_MidiControls_KNOB8;
            public InputActionMap Get() { return m_Wrapper.m_MidiControls; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MidiControlsActions set) { return set.Get(); }
            public void SetCallbacks(IMidiControlsActions instance)
            {
                if (m_Wrapper.m_MidiControlsActionsCallbackInterface != null)
                {
                    @PAD1.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD1;
                    @PAD1.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD1;
                    @PAD1.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD1;
                    @PAD2.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD2;
                    @PAD2.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD2;
                    @PAD2.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD2;
                    @PAD3.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD3;
                    @PAD3.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD3;
                    @PAD3.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD3;
                    @PAD4.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD4;
                    @PAD4.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD4;
                    @PAD4.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD4;
                    @PAD5.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD5;
                    @PAD5.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD5;
                    @PAD5.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD5;
                    @PAD6.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD6;
                    @PAD6.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD6;
                    @PAD6.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD6;
                    @PAD7.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD7;
                    @PAD7.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD7;
                    @PAD7.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD7;
                    @PAD8.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD8;
                    @PAD8.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD8;
                    @PAD8.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnPAD8;
                    @KNOB1.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB1;
                    @KNOB1.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB1;
                    @KNOB1.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB1;
                    @KNOB2.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB2;
                    @KNOB2.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB2;
                    @KNOB2.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB2;
                    @KNOB3.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB3;
                    @KNOB3.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB3;
                    @KNOB3.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB3;
                    @KNOB4.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB4;
                    @KNOB4.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB4;
                    @KNOB4.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB4;
                    @KNOB5.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB5;
                    @KNOB5.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB5;
                    @KNOB5.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB5;
                    @KNOB6.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB6;
                    @KNOB6.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB6;
                    @KNOB6.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB6;
                    @KNOB7.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB7;
                    @KNOB7.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB7;
                    @KNOB7.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB7;
                    @KNOB8.started -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB8;
                    @KNOB8.performed -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB8;
                    @KNOB8.canceled -= m_Wrapper.m_MidiControlsActionsCallbackInterface.OnKNOB8;
                }
                m_Wrapper.m_MidiControlsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @PAD1.started += instance.OnPAD1;
                    @PAD1.performed += instance.OnPAD1;
                    @PAD1.canceled += instance.OnPAD1;
                    @PAD2.started += instance.OnPAD2;
                    @PAD2.performed += instance.OnPAD2;
                    @PAD2.canceled += instance.OnPAD2;
                    @PAD3.started += instance.OnPAD3;
                    @PAD3.performed += instance.OnPAD3;
                    @PAD3.canceled += instance.OnPAD3;
                    @PAD4.started += instance.OnPAD4;
                    @PAD4.performed += instance.OnPAD4;
                    @PAD4.canceled += instance.OnPAD4;
                    @PAD5.started += instance.OnPAD5;
                    @PAD5.performed += instance.OnPAD5;
                    @PAD5.canceled += instance.OnPAD5;
                    @PAD6.started += instance.OnPAD6;
                    @PAD6.performed += instance.OnPAD6;
                    @PAD6.canceled += instance.OnPAD6;
                    @PAD7.started += instance.OnPAD7;
                    @PAD7.performed += instance.OnPAD7;
                    @PAD7.canceled += instance.OnPAD7;
                    @PAD8.started += instance.OnPAD8;
                    @PAD8.performed += instance.OnPAD8;
                    @PAD8.canceled += instance.OnPAD8;
                    @KNOB1.started += instance.OnKNOB1;
                    @KNOB1.performed += instance.OnKNOB1;
                    @KNOB1.canceled += instance.OnKNOB1;
                    @KNOB2.started += instance.OnKNOB2;
                    @KNOB2.performed += instance.OnKNOB2;
                    @KNOB2.canceled += instance.OnKNOB2;
                    @KNOB3.started += instance.OnKNOB3;
                    @KNOB3.performed += instance.OnKNOB3;
                    @KNOB3.canceled += instance.OnKNOB3;
                    @KNOB4.started += instance.OnKNOB4;
                    @KNOB4.performed += instance.OnKNOB4;
                    @KNOB4.canceled += instance.OnKNOB4;
                    @KNOB5.started += instance.OnKNOB5;
                    @KNOB5.performed += instance.OnKNOB5;
                    @KNOB5.canceled += instance.OnKNOB5;
                    @KNOB6.started += instance.OnKNOB6;
                    @KNOB6.performed += instance.OnKNOB6;
                    @KNOB6.canceled += instance.OnKNOB6;
                    @KNOB7.started += instance.OnKNOB7;
                    @KNOB7.performed += instance.OnKNOB7;
                    @KNOB7.canceled += instance.OnKNOB7;
                    @KNOB8.started += instance.OnKNOB8;
                    @KNOB8.performed += instance.OnKNOB8;
                    @KNOB8.canceled += instance.OnKNOB8;
                }
            }
        }
        public MidiControlsActions @MidiControls => new MidiControlsActions(this);
        public interface IMidiControlsActions
        {
            void OnPAD1(InputAction.CallbackContext context);
            void OnPAD2(InputAction.CallbackContext context);
            void OnPAD3(InputAction.CallbackContext context);
            void OnPAD4(InputAction.CallbackContext context);
            void OnPAD5(InputAction.CallbackContext context);
            void OnPAD6(InputAction.CallbackContext context);
            void OnPAD7(InputAction.CallbackContext context);
            void OnPAD8(InputAction.CallbackContext context);
            void OnKNOB1(InputAction.CallbackContext context);
            void OnKNOB2(InputAction.CallbackContext context);
            void OnKNOB3(InputAction.CallbackContext context);
            void OnKNOB4(InputAction.CallbackContext context);
            void OnKNOB5(InputAction.CallbackContext context);
            void OnKNOB6(InputAction.CallbackContext context);
            void OnKNOB7(InputAction.CallbackContext context);
            void OnKNOB8(InputAction.CallbackContext context);
        }
    }
}
