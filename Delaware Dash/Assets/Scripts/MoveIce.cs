using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIce : MonoBehaviour
{

    public float speed = 500;
    public Rigidbody iceRb;
    public bool hasBounced = false;
    public bool isSecondPrefab = false;



    void Start()
    {
        iceRb = GetComponent<Rigidbody>();
        if (!isSecondPrefab)
        {
            hasBounced = true;
        }
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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallR"))
        {
            hasBounced = true;
            
        }
        if (collision.gameObject.CompareTag("WallL"))
        {
            hasBounced = false;

        }
        if (collision.gameObject.CompareTag("Ice"))
        {
            if (!hasBounced) { hasBounced = true; }
            else if (hasBounced) { hasBounced = false;}
            
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
