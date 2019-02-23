using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zPlus_Floor : MonoBehaviour
{

    public GameObject Floor;
    Vector3 Pos;
    bool chk = true;

    void OnTriggerEnter(Collider col)
    {
        if (chk == true)
        {
            if (col.tag == "Player")
            {
                Pos = this.transform.position;
                Instantiate(Floor, new Vector3(Pos.x, Pos.y - 10, Pos.z + 2250), Quaternion.identity);
                chk = false;
            }
        }
    }
}
