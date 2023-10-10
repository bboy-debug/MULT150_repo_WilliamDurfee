using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggerCounter : MonoBehaviour
{
    int cubeCollisionCount = 0;                 // number of times collided starts at 0.
    int plusOne = 1;                            // number will increase by 1 (when the ball collides that is).

    void OnTriggerEnter(Collider other)         // borrowed from the TriggerScript, with my own tweaks. detects
    {                                           // whenever the ball collides with the chosen object (cube).
        cubeCollisionCount += plusOne;          // when the ball collides with the cube, the counter will go up 1.
        print("The " + other.gameObject.name + " has collided with the " + gameObject.name + " " +          // prints the number of times the other.gameObject (the sphere)
            cubeCollisionCount + " times.");                                                                // collides with the gameObject.name (the cube). note that
                                                                                                            // it detects the gameObject's name due to it having the script
                                                                                                            // I added to its component.
    }
}
