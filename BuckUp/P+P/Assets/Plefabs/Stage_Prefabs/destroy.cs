using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {
    float dead = 3.0f;
	void Start () {
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
    public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "player")
        {
            GetComponent<flore>().num=0;
            Destroy(gameObject);
        }
    }
}
