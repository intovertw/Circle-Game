using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCircle : MonoBehaviour
{
    public bool clockwise = true;
    private void Update()
    {
        if((Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) && clockwise == true)
        {
            clockwise = false;
            Debug.Log("clock wise false");
        }
        else if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) && clockwise == false)
        {
            clockwise = true;
            Debug.Log("clockwise real and true");
        }
    }
    void FixedUpdate()
    {
        if(clockwise == true)
        {
            transform.Rotate(0, 0, -180 * Time.deltaTime);
        }
        else
        {
            transform.Rotate(0, 0, 180 * Time.deltaTime);
        }
    }
}
