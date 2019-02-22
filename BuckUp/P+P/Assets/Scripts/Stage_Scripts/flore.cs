using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flore : MonoBehaviour
{
    public int num = 0;
    void Start()
    {
    }
    void Update()
    {
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            num = 1;
        }
    }
}
