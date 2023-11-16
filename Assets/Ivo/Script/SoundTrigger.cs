using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip audioToPlay;
    bool isPlaying = false;
    public float timeToDestroy;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isPlaying)
            {
                audio.PlayOneShot(audioToPlay);
                isPlaying = true;
                Destroy(gameObject, timeToDestroy);
            }
        }
          
    }

}
