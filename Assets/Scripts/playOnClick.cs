using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playOnClick : MonoBehaviour
{

    AudioSource audioData;

    // Start is called before the first frame update
    void Awake()
    {

        audioData = GetComponent<AudioSource>();
        audioData.clip = Resources.Load<AudioClip>("vibe541");
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
