﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] peoplePrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomHuman", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {    
        
    }

    void SpawnRandomHuman()
    {
        int peopleIndex = Random.Range(0, peoplePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(peoplePrefabs[peopleIndex], spawnPos,
            peoplePrefabs[peopleIndex].transform.rotation);
    }


}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class SpawnManagerX : MonoBehaviour
// {
//     public GameObject[] ballPrefabs;

//     private float spawnLimitXLeft = -22;
//     private float spawnLimitXRight = 7;
//     private float spawnPosY = 30;

//     private float startDelay = 1.0f;
//     private float spawnInterval = 4.0f;

//     // Start is called before the first frame update
//     void Start()
//     {
//         InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
//     }

//     // Spawn random ball at random x position at top of play area
//     void SpawnRandomBall ()
//     {
//         // Generate random ball index and random spawn position
//         int ballIndex = Random.Range(0, ballPrefabs.Length);
//         Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), 0, spawnPosY);

//         // instantiate ball at random spawn location
//         Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
//     }

// }

