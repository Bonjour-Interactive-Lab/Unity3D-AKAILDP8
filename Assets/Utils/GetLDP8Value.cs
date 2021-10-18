using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Bonjour;
public class GetLDP8Value : MonoBehaviour
{
    public RectTransform[] PADS;
    public RectTransform[] KNOBS;

    private AKAIController akaictrl;

    void Start()
    {
        akaictrl = this.GetComponent<AKAIController>();
        akaictrl.OnAKAIInputChange.AddListener(OnAKAIInputChange);

        foreach(RectTransform rt in KNOBS){
            Image img = rt.GetComponent<Image>();
            Material mat = Instantiate(img.material);
            mat.SetFloat("_Knob", 0);
            img.material = mat;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAKAIInputChange(AKAIController.AKAIInputChange data){
            // Debug.Log($"New input change at {data.type}{data.index}: {data.value}");
            int index = data.index;
            if(data.type == AKAIController.TYPE.PAD){
               PADS[index].GetComponent<Image>().color =  new Color(1, 1, 1, data.value);
            }else if(data.type == AKAIController.TYPE.KNOB){
               KNOBS[index].GetComponent<Image>().material.SetFloat("_Knob", data.value);
            }
        }

        private void OnDisable(){
            if(akaictrl != null) akaictrl.OnAKAIInputChange.RemoveAllListeners();
        }
}
