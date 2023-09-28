using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.SimpleLUT
{
    public class LightController : MonoBehaviour
    {
        public LightController1 lightController1;
        Slider slider2;
        SimpleLUT simpleLUT;
        // Start is called before the first frame update
        void Start()
        {
            slider2 = GetComponent<Slider>();
            simpleLUT = FindObjectOfType<SimpleLUT>();
            lightController1 = GetComponent<LightController1>();

            slider2.value = lightController1.slider.value;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void changeLightValue()
        {
            simpleLUT.Brightness = slider2.value * -1;
        }
    }
}
