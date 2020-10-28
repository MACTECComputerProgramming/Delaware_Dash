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
    public int lives = 3;




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
        if(transform.position.x < -480) { transform.position = new Vector3(-473, transform.position.y, transform.position.z); }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ice"))
        {
            lives--;
            if (lives < 1)
            { Destroy(gameObject);gameOver = true; }
            Destroy(collision.gameObject);
            
        }
    }
    public void OpenMenu()
    {

    }

}
