using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIce : MonoBehaviour
{

    public float speed = 500;
    public Rigidbody iceRb;
    public bool hasBounced = false;



    void Start()
    {
        iceRb = GetComponent<Rigidbody>();   
    }

    void Update()
    {
        if (!hasBounced)
        {
            GoRight();
        }
        if (hasBounced)
        {
            GoLeft();
        }
    }

    void GoRight()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void GoLeft()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }


}
