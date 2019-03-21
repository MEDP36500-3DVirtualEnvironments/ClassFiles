using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithMe : MonoBehaviour
{

    Rigidbody rb;
    public GameObject player;
    float distance;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(distance);
        if (distance < 5) {
            //Debug.Log("I'm close!!!!");
            GetComponent<Renderer>().material.color = Color.red;
        } else {
            GetComponent<Renderer>().material.color = Color.white;
        }

    }

    private void OnMouseDown()
    {
        Debug.Log("you clicked on me!!");
        rb.AddForce(transform.up * 10, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Debug.Log("collision!");
            audio.Play();
        }

    }

}
