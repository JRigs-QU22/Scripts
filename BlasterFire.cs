using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterFire : MonoBehaviour
{
    public GameObject blast; //allows us to set object for blast
    private Vector2 myLocation; //makes Vector 2 for blast position
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if space button is pressed
        {
            myLocation = gameObject.transform.position; //sets blast location at player position

            Instantiate(blast, new Vector2(myLocation.x, myLocation.y), transform.rotation); //makes new blast in upwards direction
        }
    }
}//Based on code provided by Liam Day

