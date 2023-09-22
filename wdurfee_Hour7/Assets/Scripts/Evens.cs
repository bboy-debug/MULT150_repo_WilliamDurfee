using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    int x = 22;                          // The starting number.
    int y = 2;                           // The number added every loop.

    // Start is called before the first frame update
    void Start()
    {
        while(x <= 100)                  // While loop that ends at 100.
        {
            Debug.Log(x);                // Prints the number amount "x".
            x += y;                      // Adds x to y aka (22 + 2), and will repeat until x reaches 100 thanks to the while loop (x <= 100).
        }
    }
        
}                                       // Remember to check Console for results.