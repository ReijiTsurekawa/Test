using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				// オマジナイ.
using UnityEngine.SceneManagement;	// オマジナイ.

public class score : MonoBehaviour
{
    public Text score_text;
    public int s = 0;

    void Start()
    {
        score_text.color = new Color(0, 0, 0);
    }
    private void Update()
    {
        GameObject GM = GameObject.Find("GM");
        score_text.text = "Score:" + GM.GetComponent<GameControl>().score.ToString();
       // Debug.Log(GM.GetComponent<GameControl>().score.ToString());
        GameObject bike = GameObject.Find("Bike");
        if (bike.GetComponent<bikeMove>().num == 1)
        {
            score_text.text = "Finish!";
        }
    }
}