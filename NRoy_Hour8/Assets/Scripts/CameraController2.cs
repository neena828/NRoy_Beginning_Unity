using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float CameraX = Input.GetAxis("Mouse X");
        if (CameraX < 0)
        {
            transform.Rotate(0f, -1f, 0f);
        }
        if (CameraX > 0)
        {
            transform.Rotate(0f, 1f, 0f);
        }        
    }
}
