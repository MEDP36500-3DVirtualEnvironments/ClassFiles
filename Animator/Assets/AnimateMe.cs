using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateMe : MonoBehaviour
{

    public GameObject player;
    Animator anim;
    float dist;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        anim.SetFloat("makeColorChange", dist);
    }

    private void OnCollisionEnter(Collision collision)
    {
        anim.SetTrigger("makeShrink");
    }

}
