/*
     * Darion Jeffries
     * DetectCollisionsX
     * Challenge2
     * Detects collisions. Adds to score and destroys objects.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
