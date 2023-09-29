using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulbSwitch : MonoBehaviour
{
    Light lightComponent;                           // a variable to store the light component.

    void Start()                                    // Start is called before the first frame update
    {
        lightComponent = GetComponent<Light> ();    // using chevrons <> to specify the type of component.
    }

    void Update()                                   // Update is called once per frame
    {
        if (Input.GetKeyDown(KeyCode.L))
            print("The 'L' key was pressed");       // displays the what key was pressed.

        if (Input.GetKeyDown(KeyCode.L))
            lightComponent.enabled = !lightComponent.enabled;   // a NOT (!) operator is used to
                                                                // reverse the result of any given
                                                                // expression or condition. thus,
                                                                // pressing the 'L' key will first result
                                                                // the light turning off. then, pressing
                                                                // the 'L' key a second time will do the 
                                                                // opposite by turning the light back
                                                                // on, and vice versa.
    }
}
