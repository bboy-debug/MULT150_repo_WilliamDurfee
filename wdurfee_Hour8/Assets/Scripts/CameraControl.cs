using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
            print("Mouse X movement selected: " + mxVal);
        if (myVal != 0)
            print("Mouse Y movement selected: " + myVal);

        float mzVal = transform.eulerAngles.z;      // I found this command that prevents the
        transform.Rotate(0, 0, -mzVal);             // camera from rotating on its z-axis
                                                    // (lines 23-24).

        transform.Rotate(myVal, mxVal, 0);          // this allows the camera to rotate
                                                    // based on the values read by the
                                                    // mouse movement inputs (lines 16-21).
    }
}                                                   
