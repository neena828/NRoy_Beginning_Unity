using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MotionScript : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //DSFFFFFFFSDFSDFSDFSDFFD
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(0.05f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(0f, 0f, 0.05f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(-0.05f, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(0f, 0f, -0.05f);
        }
    }
}
