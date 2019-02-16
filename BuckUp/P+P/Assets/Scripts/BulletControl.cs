using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletControl : MonoBehaviour
{
    public Text text_score;
    public int score=0;

    void Start()
    {
        // 最初はSETから
    }


    void Update()
    {

    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bike")
        {
            GameObject GM = GameObject.Find("GM");
            GetComponent<AudioSource>().Play();
            GM.GetComponent<GameControl>().plusScore();
            Destroy(gameObject);
        }
    }
}