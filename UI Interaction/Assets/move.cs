using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Vector3 mypos;
    Vector3 otherguyspos;
    public GameObject otherguy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mypos = transform.position;
        otherguyspos = new Vector3(mypos.x * -1, mypos.y, mypos.z * -1);
        otherguy.transform.position = otherguyspos;
        
    }
}
