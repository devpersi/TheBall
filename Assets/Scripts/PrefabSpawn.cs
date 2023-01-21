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
        // Need an endless loop, while is the most readable
        while (true)
        {
            // Wait for spawnInterval/6 seconds before running the code
            yield return new WaitForSeconds(spawnInterval);

            // Comment in below code to mess with the spawned ball's properties
            /* GameObject newBall = */ Instantiate(prefabToSpawn, this.transform);
            // newBall.tag = "ball";

            // Increment the ballcount and invoke the event being listened to by the SpawnCounter script
            ballCounter++;
            onCounterChanged.Invoke();
        }
    }
}
