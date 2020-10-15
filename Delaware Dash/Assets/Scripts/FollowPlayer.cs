using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Vector3 playerPos;
    private PlayerMovement PlayerMovementScript;
    public Vector3 offset;


    void Start()
    {
        PlayerMovementScript = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerMovementScript.playerRb.transform.position - offset;
    }
}
