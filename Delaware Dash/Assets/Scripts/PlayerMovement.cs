using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody playerRb;
    public float speed = 50;
    private float horizontalInput;
    private float verticalInput;
    public Vector3 playerPos;
    public bool gameOver = false;
    


    void Start()
    {
        
    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (!gameOver)
        {
            playerRb.AddForce(transform.forward * speed * horizontalInput * Time.deltaTime);
            playerRb.AddForce(transform.right * -speed * verticalInput * Time.deltaTime);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ice"))
        {
            Destroy(gameObject);
            gameOver = true;
        }
    }
    public void OpenMenu()
    {

    }

}
