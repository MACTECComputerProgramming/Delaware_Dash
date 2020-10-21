using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private MoveIce IceScript;


    void Start()
    {
        Invoke("SpawnObstacle", 1);
        //InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        //playerControllerScript =
            //GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        //if (IceScript.hasBounced == false)
        //{
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        //}
    }


}
