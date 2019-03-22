using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTriggerEnter : MonoBehaviour
{

    AudioSource audioData;
    Renderer rend;

    // Start is called before the first frame update
    void Awake()
    {
        audioData = GetComponent<AudioSource>();
        audioData.playOnAwake = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        audioData.Play();

    }
}
