using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody playerRb;
    public float speed = 50;
    public float horizontalInput;
    public float verticalInput;
    public Vector3 playerPos;
    



    void Start()
    {
        
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(transform.forward * speed * horizontalInput * Time.deltaTime);
        playerRb.AddForce(transform.right * -speed * verticalInput * Time.deltaTime);
        
    }
}
