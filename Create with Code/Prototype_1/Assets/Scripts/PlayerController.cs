using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 16.11F;
    private float turnSpeed = 18;
    private float horiInp;
    private float vertInp;
    
    // Update is called once per frame
    void Update()
    {
        // Get inputs
        horiInp = Input.GetAxis("Horizontal");
        vertInp = Input.GetAxis("Vertical");
        // look ma, no hands!
        /*
            - moments before crashing the car
        */
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertInp);
        // look ma, hands!
        /*
            - moments before veering the car off of a cliff
        */
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horiInp);
    }
}
