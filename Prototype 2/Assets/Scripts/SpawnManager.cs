/*
     * Darion Jeffries
     * SpawnManager
     * Prototype 2
     * Spawns prefabs within time range and within parameters
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabsToSpawn;

    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;

    void Start()
    {
        //  InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while (true)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(0.8f, 3.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //SpawnRandomPrefab();
        }
    }


    void SpawnRandomPrefab()
    {
        
        {
            //pick a random animal index
            int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

            //generate random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

            //spawn the animal
            Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
        }
    }

}
