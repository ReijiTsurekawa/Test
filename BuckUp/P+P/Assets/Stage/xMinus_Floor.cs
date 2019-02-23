using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xMinus_Floor : MonoBehaviour
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
                Instantiate(Floor, new Vector3(Pos.x - 2250, Pos.y - 10, Pos.z), Quaternion.identity);
                chk = false;
            }
        }
    }
}
