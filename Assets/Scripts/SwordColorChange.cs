using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordColorChange : MonoBehaviour
{
    public float RotateSpeed;

    // Update is called once per physics update
    void FixedUpdate() {
        RotateSpeed = GetComponent<Controls>().getRSpeed();
        if (RotateSpeed <= 500 && RotateSpeed >= 0)
        {
            RotateSpeed = GetComponent<Controls>().getRSpeed();
            GetComponent<Renderer>().material.color = Color.grey;
            
            
        }
        else if (RotateSpeed <= 1000 && RotateSpeed > 500)
        {
            RotateSpeed = GetComponent<Controls>().getRSpeed();
            GetComponent<Renderer>().material.color = Color.yellow;
           
        }
        else if (RotateSpeed <= 2000 && RotateSpeed >1000)
        {
            RotateSpeed = GetComponent<Controls>().getRSpeed();
            GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
