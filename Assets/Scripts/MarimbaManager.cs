using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarimbaManager : MonoBehaviour
{
    public GameObject hit2;
    public int amount;
    public GameObject[] cubes;
    public List<Vector3> positions = new List<Vector3>();


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < amount; i++)
        {
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            string indexString = i.ToString();
            cube.name = "cube"+ indexString;
            cube.transform.position = new Vector3(i, 2, i);
            // color is controlled like this
            cube.GetComponent<Renderer>().material.color = Color.red;

            Instantiate(hit2, new Vector3(i, 1, i), Quaternion.identity);
            AudioSource hitAudio = hit2.GetComponent<AudioSource>();
            hitAudio.pitch = (i / 2.5f * i / 2.5f);
            hitAudio.playOnAwake = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
