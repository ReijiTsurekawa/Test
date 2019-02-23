using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zm2 : MonoBehaviour
{
    int x;
    int z;
    int num = 0;
    bool check;
    [SerializeField] GameObject flore;
    void Start()
    {
        Vector3 pos = transform.position;
        x = (int)pos.x;
        z = (int)pos.z;
        check = true;
    }

    //public void OnCollisionEnter(Collision col)
    void OnTriggerEnter(Collider col)
    {
        if (check == true)
        {
            Debug.Log("zm");
            //if (col.gameObject.name == "player")
            if (col.tag == "Player")
            {

                Vector3 pos2 = new Vector3(x, 0, z + 600);
                Instantiate(flore, pos2, Quaternion.identity);
                // num++;
                check = false;
            }

        }
    }
}