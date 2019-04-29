using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{

    float speed;
    Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void sliderInput(float value)
    {
        speed = value/100;
        anim.speed = speed;
    }
}
