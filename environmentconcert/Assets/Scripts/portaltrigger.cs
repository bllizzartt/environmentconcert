using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portaltrigger : MonoBehaviour
{
    public GameObject portal;

    //This allows us to trasnfer scenes upon colliding 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Portal")
        {
            Debug.Log("New scene");
            SceneManager.LoadScene(1);
            //SceneManager.LoadScene(2);
            //SceneManager.LoadScene(3);
        }

        if (other.tag == "Portal1")
        {
            Debug.Log("New scene");
            SceneManager.LoadScene(2);
            
        }
    }
}