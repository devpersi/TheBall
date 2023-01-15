using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class SpawnCounter : MonoBehaviour
{
    public PrefabSpawn targetPrefabSpawn;
    private int prefabCount;

    // Start is called before the first frame update
    void Start()
    {
        SetText();
        targetPrefabSpawn.onCounterChanged.AddListener(SetText);
    }

    private void SetText()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        prefabCount = targetPrefabSpawn.ballCounter;
        text.text = $"Balls: {prefabCount}";
    }
}
