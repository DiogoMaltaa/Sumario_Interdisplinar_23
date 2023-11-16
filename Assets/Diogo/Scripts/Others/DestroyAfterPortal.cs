using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterPortal : MonoBehaviour
{
    public GameObject destroyLevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(destroyLevel);
        }
    }
}
