using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportMe : MonoBehaviour
{

    public GameObject dest;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.T)) {
            transform.position = dest.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.M)) {
            SceneManager.LoadScene("Scene02");
        }
    }
}
