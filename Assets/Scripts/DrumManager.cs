using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrumManager : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    public GameObject hit;   

    void Start()
    {
        GameObject hitParent = GameObject.CreatePrimitive(PrimitiveType.Cube);
        hitParent.GetComponent<MeshRenderer>().enabled = false;
        hitParent.transform.position = new Vector3(0, 0, 0);
        for (y = 0; y < 15; y += 1f)
        {
            for (x = 0; x < 15; x+= 1f)
            {
                Instantiate(hit, new Vector3(x, y, 0), Quaternion.identity);
                AudioSource hitAudio = hit.GetComponent<AudioSource>();
                hitAudio.pitch = (y / 2.5f * x / 2.5f);
                hitAudio.playOnAwake = false;

            }
        }


    }

  

}
