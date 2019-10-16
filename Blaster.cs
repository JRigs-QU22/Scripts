using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blaster : MonoBehaviour
{
    public float Yspeed; //sets a variable for vertical speed
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, Yspeed, 0); //transforms the blast position on the y-axis

    }
    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "asteroid") //if alien is hit by object with blaster tag
        { 
         Destroy(gameObject);    
        }
    }
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}//made by me but assisted by Liam Day