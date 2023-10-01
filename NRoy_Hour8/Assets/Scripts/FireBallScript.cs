using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();
        Debug.Log("Player Health " + x);
        int y = TakeDamageFromFireball(25);
        Debug.Log("Player Health " + y);
        int z = TakeDamageFromFireball(30, 50);
        Debug.Log("Play Health " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int TakeDamageFromFireball()
    {
        int playerHealth = 100;
        return playerHealth - 5;
    }
    int TakeDamageFromFireball(int damage)
    {
         int playerHealth = 100;
        return playerHealth - damage;
    }
    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;
    }
}
