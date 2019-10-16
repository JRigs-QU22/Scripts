using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = (transform.position - player.transform.position)*5;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > -9.2f)
        {
            // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
            transform.position = player.transform.position + 0.2f * offset;

        }
    }
}
