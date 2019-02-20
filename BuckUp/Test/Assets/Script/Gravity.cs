using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    const float gravity = 9.80665;
    public GameObject gravTarget;

    void FixedUpdate()
    {
        Vector3 gravDirection = gravTarget.transform.position - transform.position;
        Physics.gravity = gravDirection.normalized * gravity;
    }
}