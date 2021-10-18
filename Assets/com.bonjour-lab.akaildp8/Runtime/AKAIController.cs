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
            midiin.MidiControls.PAD1.performed += ctx => OnPadInput(ctx, 0);
            midiin.MidiControls.PAD2.performed += ctx => OnPadInput(ctx, 1);
            midiin.MidiControls.PAD3.performed += ctx => OnPadInput(ctx, 2);
            midiin.MidiControls.PAD4.performed += ctx => OnPadInput(ctx, 3);
            midiin.MidiControls.PAD5.performed += ctx => OnPadInput(ctx, 4);
            midiin.MidiControls.PAD6.performed += ctx => OnPadInput(ctx, 5);
            midiin.MidiControls.PAD7.performed += ctx => OnPadInput(ctx, 6);
            midiin.MidiControls.PAD8.performed += ctx => OnPadInput(ctx, 7);

            midiin.MidiControls.KNOB1.performed += ctx => OnKnobInput(ctx, 0);
            midiin.MidiControls.KNOB2.performed += ctx => OnKnobInput(ctx, 1);
            midiin.MidiControls.KNOB3.performed += ctx => OnKnobInput(ctx, 2);
            midiin.MidiControls.KNOB4.performed += ctx => OnKnobInput(ctx, 3);
            midiin.MidiControls.KNOB5.performed += ctx => OnKnobInput(ctx, 4);
            midiin.MidiControls.KNOB6.performed += ctx => OnKnobInput(ctx, 5);
            midiin.MidiControls.KNOB7.performed += ctx => OnKnobInput(ctx, 6);
            midiin.MidiControls.KNOB8.performed += ctx => OnKnobInput(ctx, 7);
        }

        protected void OnPadInput(InputAction.CallbackContext context, int index){
            if(logInputChange) Debug.Log($"PAD{index} trigger at vel: {context.ReadValueAsObject()}");
            AKAIInputChange data = new AKAIInputChange();
            data.type  = TYPE.PAD;
            data.index = index;
            data.value = (float) context.ReadValueAsObject();

            OnAKAIInputChange.Invoke(data);
        }

        protected void OnKnobInput(InputAction.CallbackContext context, int index){
            if(logInputChange)  Debug.Log($"Knob{index} trigger at value: {context.ReadValueAsObject()}");
            AKAIInputChange data = new AKAIInputChange();
            data.type  = TYPE.KNOB;
            data.index = index;
            data.value = (float) context.ReadValueAsObject();

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
