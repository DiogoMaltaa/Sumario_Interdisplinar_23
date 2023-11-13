using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Manager : MonoBehaviour
{
    [Header("Trigger Type")]
    public bool cenario;
    public bool evento;

    [Header("Interactable Object")]
    public GameObject tunel;

    [Header("tunel")]
    [SerializeField]
    float speed;
    [SerializeField]
    Vector3 rotationDirection = new Vector3();

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (cenario)
            {
                rotateTunnel(tunel);
            }
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (cenario)
            {
                stopTunnel(tunel);
            }
        }
    }

    private void rotateTunnel(GameObject tunel)
    {
        tunel.transform.Rotate(rotationDirection * speed * Time.deltaTime);
    }

    private void stopTunnel(GameObject tunel)
    {
        tunel.transform.Rotate(0, 0, 0);
    }

}
