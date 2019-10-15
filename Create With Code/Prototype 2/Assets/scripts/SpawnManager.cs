using System.Collections;
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
