using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKeyDown("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }



    }
}
