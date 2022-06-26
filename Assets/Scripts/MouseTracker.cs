using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracker : MonoBehaviour
{
    //public Vector3 startPos;
    //public Vector3 currPos;
    // Update is called once per frame
    void Start()
    {
        //Vector3 startPos = Input.mousePosition;
    }
    
    void Update()
    {
        //Vector3 currPos = Input.mousePosition;

        if (Input.GetAxis("Mouse X") < 0)
        {
            //Code for action on mouse moving left
            Debug.Log("Mouse moved left");
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            //Code for action on mouse moving right
            Debug.Log("Mouse moved right");
        }
        if (Input.GetAxis("Mouse X") > 0.75 || Input.GetAxis("Mouse X") < -0.75)
        {
            Debug.Log("Going too fast");
        }
        if (Input.GetAxis("Mouse X") < 0.15 || Input.GetAxis("Mouse X") > -0.15)
        {
            Debug.Log("Going too slow");
        }
    }
}
