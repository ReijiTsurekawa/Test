using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GG : MonoBehaviour
{
    public GameObject planet;   // 引力の発生する星
    public float coefficient;   // 万有引力係数

    void FixedUpdate()
    {

        // 星に向かう向きの取得
        var direction = planet.transform.position - transform.position;
        // 星までの距離の２乗を取得
        var distance = direction.magnitude;
        distance *= distance;
        // 万有引力計算
        Rigidbody rb = GetComponent<Rigidbody>();
        var gravity = coefficient * rb.mass * rb.mass / distance;

        // 力を与える
        rb.AddForce(gravity * direction.normalized, ForceMode.Force);
    }
}