using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zp : MonoBehaviour
{
    int x;
    int z;
    int num = 0;
    public GameObject flore;
    void Start()
    {
        Vector3 pos = transform.position;
        x = (int)pos.x;
        z = (int)pos.z;
    }

    void Update()
    {

    }
    public void OnCollisionEnter(Collision col)

    {

        if (col.gameObject.name == "player")
        {
            if (num == 0)
            {
                Vector3 pos2 = new Vector3(x, 0, z + 600);
                Instantiate(flore, pos2, Quaternion.identity);
                num++;
            }

        }
    }
}