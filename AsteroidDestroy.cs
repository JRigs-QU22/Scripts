using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidDestroy : MonoBehaviour
{
    public AudioSource Blown; //sets audio source for Asteroid Destroy sound
    public Text TellPlayer;
    int ast = 0;
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "blaster") //if alien is hit by object with blaster tag
        {
            

            Blown.Play(); //play alien destroy audio


            Destroy(gameObject); //destroy object after a half-second delay
            ast++;
            TellPlayer.text = "Asteroids Destroyed: " + ast;


        }

    }
    void Update()
    {

    }
}//made by me but assisted by Shawn Urban
