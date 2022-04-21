//This script allows audio to ber played upon a colliding event
//------debating if i will be using this!!!------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource platformsound;
    // Start is called before the first frame update
    void Start()
    {
        platformsound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            // Debug
        }
    }
}