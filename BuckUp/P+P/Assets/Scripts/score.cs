using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
    static public int denemy=0;//消えた敵数
    private Text Scoretext;//スコア用の文字
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Scoretext.text = denemy.ToString("000") + "/100" ;//スコアの表示
    }
}
