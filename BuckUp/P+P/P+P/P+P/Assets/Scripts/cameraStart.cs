using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraStart : MonoBehaviour { 
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void FixedUpdate() {
        Vector3 bike = GameObject.Find("bike").transform.position;
        GameObject.Find("fmcamera").transform.position = new Vector3(bike.x-100, bike.y +70, bike.z);
    }
}
