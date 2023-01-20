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
        frequencySlider.value = targetPrefabSpawn.spawnInterval;
        SetText(targetPrefabSpawn.spawnInterval);
        frequencySlider.onValueChanged.AddListener(ChangeFrequency);
        frequencySlider.onValueChanged.AddListener(SetText);
    }
    void ChangeFrequency(float value) => targetPrefabSpawn.spawnInterval = value;

    private void SetText(float value)
    {
        TMP_Text text = GetComponentInChildren<TMP_Text>();
        string textString = (value / 6).ToString().Length > 4 ? 
            (value / 6).ToString().Substring(0, 4) : (value / 6).ToString();
        text.text = $"Frequency: 1 ball per {textString} seconds";
    }
}
