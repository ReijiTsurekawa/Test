using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroal : MonoBehaviour
{

    private Vector3 base_pos;

    private GameObject player;                  // playerと連携用.

    void Start()
    {
        player = GameObject.Find("bike");  // playerと連携.
    }

    void Update()
    {

        // カメラ操作.
        Vector3 pos = transform.position;
        Vector3 rot = transform.eulerAngles;

        rot.y = player.transform.eulerAngles.y;
        pos = player.transform.position;
        pos += -player.transform.forward * 5.0f + Vector3.up * 1.5f;

        pos = Vector3.Lerp(transform.position, pos, 2.0f * Time.deltaTime);
        rot = Vector3.Lerp(transform.eulerAngles, rot, 1.0f * Time.deltaTime);
        transform.eulerAngles = rot;
        transform.position = pos;
        transform.LookAt(player.transform.position);
        pos.y = player.transform.position.y+ 30.0f;
        transform.position = pos;
    }

}