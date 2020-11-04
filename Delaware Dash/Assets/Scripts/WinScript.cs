using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{


    public Rigidbody winRb;



    void OnCollisionEnter()
    {
        SceneManager.LoadScene(2);
    }
}
