using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;

public class GameControl : MonoBehaviour
{
    public Text text_score;
    public int score;

    void Start()
    {
        text_score.color = new Color(0, 0, 0);
    }

    void Update()
    {
        /*
                       if (Input.anyKeyDown)
                       {
                           SceneManager.LoadScene("title");
                       }
         */
    }
    public void plusScore()
    {
        score++;
        print(score);
        GetComponent<AudioSource>().Play();
    }
}