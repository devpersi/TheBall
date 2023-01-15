using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSlider : MonoBehaviour
{
    public Light targetLight;
    
    // Start is called before the first frame update
    void Start()
    {
        Slider intensitySlider = GetComponent<Slider>();
        intensitySlider.value = targetLight.intensity;
        intensitySlider.onValueChanged.AddListener(ChangeIntensity);
    }
    void ChangeIntensity(float value) => targetLight.intensity = value;
}
