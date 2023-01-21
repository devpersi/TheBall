using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WorldBoundsChecker : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "other": the collider of the gameobject colliding with the bounds
        // "2f": 2 seconds delay after collision before object destruction
        Destroy(other.gameObject, 2f);
    }
}
