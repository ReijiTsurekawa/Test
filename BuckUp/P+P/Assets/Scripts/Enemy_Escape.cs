using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Escape : MonoBehaviour
{
    public float speed;
    Vector3 Bike;
    Vector3 force;
    Rigidbody RB;

    void Start()
    {

    }

    void update()
    {

    }

    void OnTriggerStay(Collider col)
    {
        //　プレイヤーキャラクターを発見
        if (col.tag == "Player")
        {
            Bike = GameObject.Find("Bike").transform.position;
            RB = this.GetComponent<Rigidbody>();
            Transform Ene = this.transform;

            Vector3 pos = Ene.position;

            pos.x -= Bike.x;
            pos.z -= Bike.z;
            force = new Vector3(pos.x / 5, 0.0f, pos.z / 5);
            Debug.Log(force);
            //Ene.position = pos;

            RB.AddForce(force);
        }
        else
        {
            speed = 0;
        }

    }
}
