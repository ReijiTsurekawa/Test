using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zm : MonoBehaviour
{
    int x;
    int z;
    int num = 0;
    public GameObject next;
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
                Vector3 pos2 = new Vector3(x, 0, z - 700);
                Debug.Log("(" + pos2.x + "," + pos2.z + ")");
                Instantiate(next, pos2, Quaternion.identity);
                num++;
            }
        }
    }
}