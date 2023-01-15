using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PrefabSpawn : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnInterval;

    public UnityEvent onCounterChanged;

    [SerializeField]
    public int ballCounter;
    
    // Start is called before the first frame update
    void Start()
    {
        ballCounter = 0;
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            ballCounter++;
            onCounterChanged.Invoke();
        }
    }
}
