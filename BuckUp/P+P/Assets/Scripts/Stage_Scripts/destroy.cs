using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    float dead = 7.0f;
	void Start () {
        Invoke("OnTriggerExit",3.0f);
	}
	void Update () {
        dead = dead - Time.deltaTime;
        if (dead <= 0.0f)
        {
            Destroy(this.gameObject);
        }
        if (GetComponent<flore>().num == 1)
        {
            float time = dead;
            dead = time;
        }
	}
    void OnTriggerExit(Collider col)
    {
        //if (col.gameObject.name == "player")
        if (col.tag == "Player")
        {
            GetComponent<flore>().num=0;
            Destroy(this.gameObject);
            Debug.Log("通過");
        }
    }
}
