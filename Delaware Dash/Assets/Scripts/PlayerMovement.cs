using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
     //   GetComponent<Rigidbody>();
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
            Destroy(collision.gameObject);
            if (lives < 1)
            { 
                //Destroy(gameObject);
                gameOver = true;
                SceneManager.LoadScene(0);
            }
            
            
        }
    }
    public void OpenMenu()
    {

    }

}
