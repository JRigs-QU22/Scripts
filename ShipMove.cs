using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShipMove : MonoBehaviour
{
    public AudioSource thrust; // audio source for thruster sound
    public AudioSource Hit; //audio source for asteroid hit sound
    public Text tellplay; // text field to update
 
    int hits; // counts how many times player gets hit


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow)) //if up arrow key is pressed, move in up direction
        {
            thrust.Play(); //play thruster audio
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 12);


        }
        else
        {
            thrust.Stop(); //stop thruster audio
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0); //if no button is pressed, don't move at all
        }


        if (transform.position.y > 73) // if player moves above here...
        {
            SceneManager.LoadScene("Scene_Win"); // go to win sscreen
        }
    }
    void OnCollisionEnter2D(Collision2D collision) // on collision
    {
        
        if (collision.gameObject.tag == "asteroid") //if ship is hit by object with asteroid tag
        {
         
            Hit.Play(); //play hit audio
            hits++; //increase hit int by one
            Debug.Log("i HIT AN ASTEROID"); //send message o console to show collision worked
            tellplay.text = "Hits Taken:" + hits; //Print this to console

            if (hits > 4) //if you get hit 5 times
            {
                Destroy(gameObject); //destroy ship

                SceneManager.LoadScene("Scene_Lose"); //Load lose screen
            }
        }
    }


}

