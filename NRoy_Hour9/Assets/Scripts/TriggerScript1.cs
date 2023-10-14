using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{
    public GameObject triggeredObject;
    // Start is called before the first frame update
    void Start()
    {
        //SFSDFDSFSDFDSFF
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " has entered the " + triggeredObject);
    }
    void OnTriggerStay (Collider other)
    {
        print(other.gameObject.name + " is still in the " + triggeredObject);
    }
    void OnTriggerExit (Collider other)
    {
        print(other.gameObject.name + " has left the " + triggeredObject);
    }  
}
