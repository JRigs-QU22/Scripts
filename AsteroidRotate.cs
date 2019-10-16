using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = 40;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}// based on Lab 3 Example by Professor Bertozzi
