using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballon : MonoBehaviour {
    Vector3 pos;
    Vector3 posStart;

    public GameObject ballons;

    float time = 0;
    // Use this for initialization
    void Start () {
        pos = this.transform.position;
        posStart = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
     
        pos.y++;

        transform.position = (pos);

        time += Time.deltaTime * 1;

        if (time>5)
        {
     
            Instantiate(ballons,posStart,Quaternion.identity);
            Destroy(this.gameObject);
        }
        
            

    }
}
