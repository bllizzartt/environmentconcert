using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    public GameObject platformMove;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Moved platform");
            platformMove.GetComponent<Animator>().Play("Platform");
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}