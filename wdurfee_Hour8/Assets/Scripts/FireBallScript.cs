using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int x = TakeDamageFromFireball();   //calls for int TakeDamageFromFireball() |...|
        Debug.Log("Player health: " + x);   //prints after returning.

        int y = TakeDamageFromFireball(25); //calls for int TakeDamageFromFireball(int damage) ||...||
        Debug.Log("Player health: " + y);   //prints after returning.

        int z = TakeDamageFromFireball(30, 50); //calls for int TakeDamageFromFireball(int damage, int playerHealth) |||...|||
        Debug.Log("Player health: " + z);   //prints after returning.
    }

    int TakeDamageFromFireball()
    {
        int playerHealth = 100;             // |...|    
        return playerHealth - 5;            // returns to Debug.Log("Player health: " + x);
    }

    int TakeDamageFromFireball(int damage)
    {
        int playerHealth = 100;             // ||...|| 
        return playerHealth - damage;       // returns to Debug.Log("Player health: " + y);
    }

    int TakeDamageFromFireball(int damage, int playerHealth)
    {
        return playerHealth - damage;       // |||...||| 
    }                                       // returns to Debug.Log("Player health: " + z);

}
