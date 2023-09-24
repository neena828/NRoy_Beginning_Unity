using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    public int month = 1;
    public int day = 1;
    void Start()
    {
        
    }

    void Update()
    {
        while (!(month == 13))
        {
            if (!(month == 8))
            { 
                Debug.Log (month);
                month ++;
            }
            else
            {
                Debug.Log ("It's my Birthday!");
                month ++;
            }
        } 
        while (!(day == 32))
        {
            if (!(day == 28))
            { 
                Debug.Log (day);
                day ++;
            }
            else
            {
                Debug.Log ("It's my Birthday!");
                day ++;
            }
        } 
    }
}
