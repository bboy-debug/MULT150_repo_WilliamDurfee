using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LSAnimationControl : MonoBehaviour
{
    public GameObject LightsaberVariant;
    // Update is called once per frame
    void Update()
    {
        // color change
        if (Input.GetButtonDown("A_key"))
        {
            LightsaberVariant.GetComponent<Animator>().Play("LSColorChange");
        }

        // scale change
        if (Input.GetButtonDown("D_key"))
        {
            LightsaberVariant.GetComponent<Animator>().Play("LSScaleChange");
        }

        // rotation change
        if (Input.GetButtonDown("S_key"))
        {
            LightsaberVariant.GetComponent<Animator>().Play("LSRotationChange");
        }

        // position change
        if (Input.GetButtonDown("W_key"))
        {
            LightsaberVariant.GetComponent<Animator>().Play("LSPositionChange");
        }
    }
}
