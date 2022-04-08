using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portaltrigger : MonoBehaviour
{
    public GameObject portal;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Portal")
        {
            Debug.Log("New scene");
            SceneManager.LoadScene(1);
        }
    }
}