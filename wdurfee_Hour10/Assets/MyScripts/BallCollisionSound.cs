using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionSound : MonoBehaviour
{
    public AudioSource punchSource;

    // Start is called before the first frame update
    void Start()
    {
        punchSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Blue")
        {
            punchSource.Play();
        }

        if (collision.gameObject.tag == "Red")
        {
            punchSource.Play();
        }

        if (collision.gameObject.tag == "Orange")
        {
            punchSource.Play();
        }

        if (collision.gameObject.tag == "Green")
        {
            punchSource.Play();
        }
    }
}
