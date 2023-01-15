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
        frequencySlider.onValueChanged.AddListener(ChangeIntensity);
        frequencySlider.onValueChanged.AddListener(SetText);
    }
    void ChangeIntensity(float value) => targetPrefabSpawn.spawnInterval = value;

    private void SetText(float value)
    {
        TMP_Text text = GetComponentInChildren<TMP_Text>();
        text.text = $"Frequency: 1 ball per {value} seconds";
    }
}
