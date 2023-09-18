/*
     * Darion Jeffries
     * DestroyOutOfBoundsX
     * Challenge2
     * Destroys objects out of bounded set perimeter.
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    public float leftLimit = -30;
    public float bottomLimit = -5;


    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
            print(transform.position.x);
            print("Dead");
        } 
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
            ScoreManager.health--;
        }

    }
}
