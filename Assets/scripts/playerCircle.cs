using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class playerCircle : MonoBehaviour
{
    public bool clockwise = true;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && clockwise == true)
        {
            clockwise = false;
            Debug.Log("clock wise false");
        }
        else if (Input.GetMouseButtonDown(0) && clockwise == false)
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
