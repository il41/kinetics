using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadNewKick : MonoBehaviour
{
    Collider col;
    public GameObject soundPrefab;
    float height;
    float x;
    float y;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
        x = this.transform.position.x;
        y = this.transform.position.y;
        z = this.transform.position.z;
        height = col.bounds.size.y;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        var sound = Instantiate(soundPrefab, new Vector3(x,y+(height),z), Quaternion.identity);
    }
}
