using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarRotate : MonoBehaviour
{
    public GameObject platformMove;

    //This lets us determine our movement of gameobjects based on animating and collider interaction 
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