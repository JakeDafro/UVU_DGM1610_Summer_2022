using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    public GameObject[] healthPrefab; // Array to store ufo ships

    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    private float startDelay = 5f;

    private float spawnInterval = 3f;

    
    
    void Start()
    {
        InvokeRepeating("SpawnHealth", startDelay, spawnInterval);
    }

   

    // Update is called once per frame
    void Update()
    {
       
        
    }
    void SpawnHealth()
    {
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ );
         int healthIndex = Random.Range(0,healthPrefab.Length); // Picks random UFO Array
         Instantiate(healthPrefab[healthIndex], spawnPos, healthPrefab[healthIndex].transform.rotation);
         
    }
}