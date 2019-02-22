using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float speed = 10.0f;
    float lr_speed = 0.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            lr_speed = lr_speed + 2.0f;
            if (lr_speed >= 8.0f)
            {
                lr_speed = 8.0f;
            }
        }
        else if (lr_speed > 0.0f)
        {
            lr_speed = lr_speed - 0.2f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            lr_speed = lr_speed - 2.0f;
            if (lr_speed <= -8.0f)
            {
                lr_speed = -8.0f;
            }
        }
        else if (lr_speed < 0.0f)
        {
            lr_speed = lr_speed + 0.2f;
        }
        transform.Translate(speed, 0,lr_speed);
    }
}