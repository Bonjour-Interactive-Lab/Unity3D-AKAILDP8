using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Bonjour;

namespace Bonjour{
    public class AKAIController : MonoBehaviour
    {
        private MidiInputs midiin;
        public bool logInputChange;

        public struct AKAIInputChange{
            public TYPE type;
            public int index;
            public float value;
        }

        public class AKAIEvent : UnityEvent<AKAIInputChange>{};
        public AKAIEvent OnAKAIInputChange = new AKAIEvent();


        public enum TYPE{
            KNOB,
            PAD
        }

        private void Awake(){
            midiin = new MidiInputs();
            InitEvents();
            // midiin.MidiControls.PAD1.performed += context  => OnPadInput(context, 1);
        }

        protected void InitEvents(){

            foreach (var action in midiin.asset)
            {
                if (action.type == InputActionType.Button)
                {
                    action.performed += ctx => OnPadInput(ctx);
                }
                else if (action.type == InputActionType.Value)
                {
                    action.performed += ctx => OnKnobInput(ctx);
                }
            }
        }

        protected void OnPadInput(InputAction.CallbackContext context){
            int index = int.Parse((context.action.name[context.action.name.Length - 1]).ToString()) - 1;
            if (logInputChange) Debug.Log($"PAD{index} trigger at vel: {context.ReadValueAsObject()}");
            AKAIInputChange data = new AKAIInputChange();
            data.type  = TYPE.PAD;
            data.value = (float) context.ReadValueAsObject();
            data.index = index;

            OnAKAIInputChange.Invoke(data);
        }

        protected void OnKnobInput(InputAction.CallbackContext context){
            int index = int.Parse((context.action.name[context.action.name.Length - 1]).ToString()) - 1;
            if (logInputChange)  Debug.Log($"Knob{index} trigger at value: {context.ReadValueAsObject()}");
            AKAIInputChange data = new AKAIInputChange();
            data.type  = TYPE.KNOB;
            data.value = (float) context.ReadValueAsObject();
            data.index = index;

            OnAKAIInputChange.Invoke(data);
        }


        private void OnEnable() {
            midiin.MidiControls.Enable();
        }

        private void OnDisable() {
            midiin.MidiControls.Disable();
        }
    }
}
