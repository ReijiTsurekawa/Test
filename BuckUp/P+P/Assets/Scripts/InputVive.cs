using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputVive : MonoBehaviour {
	float Vive_Y;
	// Use this for initialization
	void Start () {
		Vive_Y = 0;
	}
	public void Vive_Y_set(float y){
		Vive_Y = y;
	}

	public float Vive_Y_get(){
		return Vive_Y;
	}
}
