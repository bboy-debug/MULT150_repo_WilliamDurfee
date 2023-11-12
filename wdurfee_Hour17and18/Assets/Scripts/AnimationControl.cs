using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    void Start()
    {
        // Get a reference to the animator
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        // SetFloat (<name> , <value>);
        anim.SetFloat ("Speed", Input.GetAxis("Vertical"));
        anim.SetFloat ("Direction", Input.GetAxis("Horizontal"));
    }
}
