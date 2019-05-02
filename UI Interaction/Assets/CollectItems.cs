using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectItems : MonoBehaviour
{
    public GameObject icon;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Debug.Log("player collision");

            icon.SetActive(true);

            Destroy(this.gameObject);

            SceneManager.LoadScene(0);

        }
    }

}
