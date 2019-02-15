using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpPlayercamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 bike = GameObject.Find("bike").transform.position;
        GameObject.Find("fmcamera").transform.position = new Vector3(bike.x-20, bike.y + 30, bike.z);
        bike = GameObject.Find("bike").transform.localEulerAngles;
        GameObject.Find("fmcamera").transform.localEulerAngles = new Vector3(bike.x, bike.y, bike.z);
    }
}
