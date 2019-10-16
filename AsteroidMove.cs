using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMove : MonoBehaviour
{
    float speed = 0.6f; //creates float for speed
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 9) // if the box goes beyond the right edge, make speed negative
        {
            speed = -speed;

        }
        else if (transform.position.x < -9) //if the box goes beyond the left edge make it positive again
        {
            speed = -speed;

        }
        Vector2 newPos = new Vector2(transform.position.x + speed, transform.position.y); // makes a new Vector 2 to add speed to position to make ledge move

        transform.position = newPos; //puts the ledge in the new position

    }
} //based on lab one class example by Professor Bertozzi (found here: http://mywebspace.quinnipiac.edu/egbertozzi/210/UnityPractice/labOne.html)


