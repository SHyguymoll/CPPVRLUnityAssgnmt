using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.5F;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // look ma, no hands!
        /*
            - moments before crashing the car
        */
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
