using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTrigger : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 1000;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag == "good"){
            rb.AddForce(100f, 0, 100f);
        }

        if(col.gameObject.tag == "bad"){
            Destroy(gameObject);
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
