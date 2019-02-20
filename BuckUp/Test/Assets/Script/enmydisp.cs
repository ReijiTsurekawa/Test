using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class enmydisp : MonoBehaviour {
    public AudioClip sound01;
    // Use this for initialization
    void Start () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        // Update is called once per frame
        if (col.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();//SEをならす
            Destroy(this.gameObject);//敵の消滅処理
            //score.denemy++;//敵の消滅カウントを増やす
        }
    }
}
