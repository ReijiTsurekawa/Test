using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletControl : MonoBehaviour
{
    public Text text_score;
    public int score=0;

 

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bike")
        {
            GameObject GM = GameObject.Find("GM");
            GM.GetComponent<GameControl>().plusScore();
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}