using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class me : MonoBehaviour
{
    Rigidbody rb;
    public float movement = 1;

    float up;
    float side;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        side = Input.GetAxis("Vertical") * movement * Time.deltaTime;
        up = Input.GetAxis("Horizontal") * movement * Time.deltaTime;

        rb.AddForce(transform.right * up * Time.deltaTime);
        rb.AddForce(transform.up * side * Time.deltaTime);
    }
}
