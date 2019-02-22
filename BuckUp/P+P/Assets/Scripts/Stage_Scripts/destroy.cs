using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    float dead = 7.0f;
    void Start()
    {
    }
    void Update()
    {
        dead = dead - Time.deltaTime;
        if (dead <= 0.0f)
        {
            Destroy(this.gameObject);
            Debug.Log("dest");
        }
        if (GetComponent<flore>().num == 1)
        {
            float time = dead;
            dead = time;
        }
    }
    /*public void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "player")
        {*/
    public void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            GetComponent<flore>().num = 0;
            Destroy(this.gameObject);
        }
    }
}
