using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulbSwitch : MonoBehaviour
{
    //Start is called before the first frame update
    public GameObject lightComponent;
    public bool IO;

    void Start()
    {
        IO = true;
    }

    //Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            IO = !IO;
            lightComponent.GetComponent<Light>().enabled = IO;
        }
    }
}
