using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosCollisionSound : MonoBehaviour
{
    public AudioSource thudSource;

    // Start is called before the first frame update
    void Start()
    {
        thudSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Chaos")
        {
            thudSource.Play();
        }
    }
}
