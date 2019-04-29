using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickHit : MonoBehaviour
{
    AudioSource audioData;
    float pitch;

    // Start is called before the first frame update
    void Awake()
    {

        audioData = GetComponent<AudioSource>();
        //audioData.playOnAwake = false;
        Debug.Log(GetComponent<Collider>().bounds.size.x);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<AudioSource>().pitch = GetComponent<Collider>().bounds.size.x;
    }
    private void OnTriggerEnter(Collider other)
    {
        audioData.Play();
    }
}