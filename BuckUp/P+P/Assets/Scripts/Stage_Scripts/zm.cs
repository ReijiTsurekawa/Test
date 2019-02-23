using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zm : MonoBehaviour
{
    int x;
    int z;
    int num = 0;
    bool check;
    public GameObject flore;
    void Start()
    {
        Vector3 pos = transform.position;
        x = (int)pos.x;
        z = (int)pos.z;
        check = true;
    }

    void Update()
    {

    }
    //public void OnCollisionEnter(Collision col)
    void OnTriggerEnter(Collider col)
    {

        //if (col.gameObject.name == "player")
        if (col.tag == "Player")
        {
            if (check == true)
            {
                if (num == 0)
                {
                    Vector3 pos2 = new Vector3(x, 0, z - 700);
                    Instantiate(flore, pos2, Quaternion.identity);
                    num++;
                    check = false;
                }
            }

        }
    }
}