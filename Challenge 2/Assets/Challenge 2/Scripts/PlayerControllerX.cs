/*
     * Darion Jeffries
     * PlayerControllerX
     * Challenge2
     * Adds unspammable spacebar action to spawn dogs.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float spawnCooldown = 1.0f;
    private bool canSpawn = true;

    // Update is called once per frame
    private void Update()
    {

        // On spacebar press, send dog
        if (canSpawn && Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SpawnDogWithCooldown());
        }
    }

    private IEnumerator SpawnDogWithCooldown()
    {
        canSpawn = false;
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        yield return new WaitForSeconds(spawnCooldown);
        canSpawn = true;

    }
}
