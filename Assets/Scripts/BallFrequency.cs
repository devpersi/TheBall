using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class BallFrequency : MonoBehaviour
{
    public PrefabSpawn targetPrefabSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Slider frequencySlider = GetComponent<Slider>();

        // Call "ChangeFrequency" and "SetText" methods at start
        ChangeFrequency(frequencySlider.value);
        SetText(targetPrefabSpawn.spawnInterval);

        // Call "ChangeFrequency" and "SetText" methods only on slider value change
        frequencySlider.onValueChanged.AddListener(ChangeFrequency);
        frequencySlider.onValueChanged.AddListener(SetText);
    }

    // The listeners pass the slider value as the value parameter
    // Change the frequency used by the PrefabSpawn script to instantiate each prefab
    void ChangeFrequency(float value) => targetPrefabSpawn.spawnInterval = value;

    private void SetText(float value)
    {
        TMP_Text text = GetComponentInChildren<TMP_Text>();

        // Truncate digits after the 4th
        string hzString = (1/value).ToString().Length > 4 ? 
            (1/value).ToString().Substring(0,4) : (1/value).ToString();
        string periodString = (value).ToString().Length > 4 ? 
            (value).ToString().Substring(0, 4) : (value).ToString();
        text.text = $"Frequency: 1 ball per {periodString} seconds ({hzString})Hz";
    }
}
