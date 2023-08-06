using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed;
    private float speedBase = 100;
    private float speedMax = 0.5f;
    private float speedMin = 0.01f;
    private float rotationSpeed; 
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput);

        // positive angle should increase the speed up to a threshold (max)
        // negative angle should descrease the speed to a min. 
        // maximum angle of 50 degrees (x)

        speed = transform.localEulerAngles.x / 10000 + speed;

        if (speed >= speedMax)
        {
            speed = speedMax;
        }
        
        if (speed <= speedMin)
        {
            speed = speedMin;
        }

    }
}
