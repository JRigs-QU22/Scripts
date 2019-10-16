using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
 
    private Transform transform; //allows transforming camera to cause shake

    private float shakeDuration = 0f; //sets how long shake lasts

    private float shakeMagnitude = 0.7f; //sets how strong the shake will be

    private float dampingSpeed = 1.0f; //sets how quickly the shake dies down

    Vector3 initialPosition; //sets initial position of camera

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if (transform == null) //if there is no change in transform
        {
            transform = GetComponent(typeof(Transform)) as Transform; //get camera coordinates
        }
    }

    void OnEnable()
    {
        initialPosition = transform.localPosition; //set initial position as camera current position
    }

    // Update is called once per frame
    void Update()
    {
        if (shakeDuration > 0) // if there is a shake
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude; //sets parameters for shake location, strength, etc.

            shakeDuration -= Time.deltaTime * dampingSpeed; //how quickly shake comes and goes
        }
        else //otherwise have camera position remain unchanged
        {
            shakeDuration = 0f; 
            transform.localPosition = initialPosition;
        }
    }
    public void TriggerShake() //void to allow reference in other scripts
    {
        shakeDuration = 2.0f; //duration of shake
    }
} //script instructions from medium.com user Matt Buckley (found here: https://medium.com/@mattThousand/basic-2d-screen-shake-in-unity-9c27b56b516)
