using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kin_Del : MonoBehaviour {
    public float delTime;
	// Use this for initialization
	void Start () {
        Destroy(gameObject,delTime);
	}
	
}
