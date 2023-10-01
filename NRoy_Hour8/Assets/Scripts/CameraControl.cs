using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float CameraY = Input.GetAxis("Mouse Y");
        if (CameraY < 0)
        {
            transform.Rotate(1f, 0f, 0f);
        }
        if (CameraY > 0)
        {
            transform.Rotate(-1f, 0f, 0f);
        }
    }
}
