/*
     * Darion Jeffries
     * SpawnManagerX
     * Challenge2
     * Spawns ball at random intervals after set amount of time.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(spawnInterval);

        while (true)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(startDelay, 3.0f);
            yield return new WaitForSeconds(randomDelay);
        }
    }

    
    // Spawn random ball at random x position at top of play area
    void SpawnRandomPrefab()
    {
        int prefabIndex = Random.Range(0, ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[prefabIndex], spawnPos, ballPrefabs[prefabIndex].transform.rotation);
    }

}
