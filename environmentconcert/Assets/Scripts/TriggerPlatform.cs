//This script lets us move our object thorugh the use of animator
//We can also activate object movement thorugh the use of a trigger or have the objects transform how I want to in a loop
//Having issues with animator but will figure it out
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlatform : MonoBehaviour
{
    public GameObject platformMove;

    //This lets us determine our movement of gameobjects based on animating and collidder interaction 
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