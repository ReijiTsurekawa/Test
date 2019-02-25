using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class result : MonoBehaviour
{
    public float timer = 10.0f;
    public Text Text_Score;
    int s;
    void Start()
    {
        s = GameControl.FS();
        Text_Score.text = "Score:" + s.ToString();
    }



    void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer <= 0.0f)
        {
            SceneManager.LoadScene("title");
        }
    }
}
