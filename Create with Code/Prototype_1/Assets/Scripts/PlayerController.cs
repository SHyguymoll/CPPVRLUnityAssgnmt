using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.5F;
    public float turnSpeed;
    public float horiInp;
    public float vertInp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horiInp);
    }
}
