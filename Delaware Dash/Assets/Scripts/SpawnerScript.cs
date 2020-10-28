using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{


    public GameObject[] icePrefab;
    public GameObject spawnerPrefab;
    public int spawnRangeLow = -30;
    public int spawnRangeHigh = -400;
    public float xRange = 35;
    public int spawnerNum = 50;
      

    
    private float startDelay = 2;
    private float repeatRate = 2;
    





    void Start()
    {
        while (spawnerNum > 0)
        {
            Invoke("SpawnSpawner", 0);
            spawnerNum--;
        }
        
        Invoke("SpawnIce", 1);
        //InvokeRepeating("SpawnIce", startDelay, repeatRate);
        
        
    }

    

    void Update()
    {
        
    }

    void SpawnIce()
    {
        Vector3 spawnPos = new Vector3
        (/*Random.Range(spawnRangeLow, spawnRangeHigh)*/transform.position.x, 0, Random.Range(-xRange, xRange));

        int iceIndex = Random.Range(0, icePrefab.Length);
        Instantiate(icePrefab[iceIndex], spawnPos, icePrefab[iceIndex].transform.rotation);
        
    }

    
    void SpawnSpawner() 
    {
        Vector3 spawnPos = new Vector3
        (Random.Range(spawnRangeLow, spawnRangeHigh), 0, Random.Range(-xRange, xRange));
        //int animalIndex = Random.Range(0, animalPrefabs.Length); 
        Instantiate(spawnerPrefab, spawnPos, spawnerPrefab.transform.rotation);
    }
   

}
