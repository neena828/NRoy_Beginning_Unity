using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCountScript : MonoBehaviour
{
    int triggerCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter ()
    {
        triggerCount++;
        Debug.Log(triggerCount);
    }
}