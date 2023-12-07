using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject cameraTarget;
    public Vector3 offset = new Vector3(0,5.7F,-5.37F);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = cameraTarget.transform.position + offset;
    }
}
