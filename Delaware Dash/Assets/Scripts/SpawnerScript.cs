using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{


    public GameObject[] icePrefab;
    public GameObject spawnerPrefab;
    public GameObject redCoatPrefab;
    public int spawnRangeLow = -30;
    public int spawnRangeHigh = -400;
    public float xRange = 35;
    public int spawnerNum = 50;
    public bool isRedCoatSpawner = false;
      

    
    private float startDelay = 2;
    private float repeatRate = 2;
    public float spawnRangeHighEnd = -490;
    public float spawnRangeLowEnd = -480;

    void Start()
    {
        if (!isRedCoatSpawner)
        {
            while (spawnerNum > 1)
            {
                Invoke("SpawnSpawner", 0);
                spawnerNum--;
            }

            Invoke("SpawnIce", 0);
        }
        //InvokeRepeating("SpawnIce", startDelay, repeatRate);

        if (isRedCoatSpawner) { Invoke("SpawnRedCoat", 0); }
        
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
   
    void SpawnRedCoat()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeHighEnd, spawnRangeLowEnd), 0, Random.Range(-xRange, xRange));
        Instantiate(redCoatPrefab, spawnPos, redCoatPrefab.transform.rotation);
    }

}
