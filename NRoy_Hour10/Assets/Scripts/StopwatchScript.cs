using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StopwatchScript : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    private bool isGameOver = true;
    float time;
    bool startTimer;
    public TMP_Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        startTimer = true;
    }

    // Update is called once per frame
    void Update()
    { 
        isGameOver = blue.isSolved && green.isSolved && red.isSolved &&
        orange.isSolved;
        if(startTimer)     

            {         
                time += Time.deltaTime;    
            } 

        double b = System.Math.Round (time, 2);  
        timerText.text = b.ToString ();
        if(isGameOver)
        {
            startTimer = false;
        }
    }
}
