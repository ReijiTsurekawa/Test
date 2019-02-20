using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour {
    public enum STEP
    {            // 状況STEP作成.
        NONE = -1,
        SET,
        START,
        PLAY,
        CLEAR,
    }
    private STEP step;          // 今のSTEP.
    private STEP next_step;     // 次のSTEP.
    private float step_timer;   // 経過時間を入れる.
    public float count_timer = 5.0f;
    public Text down;

    void Start()
    {
        next_step = STEP.SET;
        down.color=new Color(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        step_timer += Time.deltaTime;
        if (next_step != STEP.NONE)
        {
            step = next_step;
            next_step = STEP.NONE;
            step_timer = 0.0f;
            switch (step)
            {
                case STEP.SET:
                    next_step = STEP.START;
                    break;
            }
        }
        switch (step)
        {
            case STEP.START:
                count_timer -= Time.deltaTime;
                down.text = ((int)count_timer).ToString();
                if (count_timer <=0.3f)
                {
                    down.color = new Color(0, 0, 0, 0);
                    next_step = STEP.PLAY;
                }
                break;
            case STEP.PLAY:
                GameObject bike = GameObject.Find("Bike");
                if (bike.GetComponent<bikeMove>().num == 1)
                {
                    next_step = STEP.CLEAR;
                }
                    break;
            case STEP.CLEAR:
                GameObject GM = GameObject.Find("GM");
                down.color=new Color(255, 0, 0, 1);
                down.text = "Score:" + GM.GetComponent<GameControl>().score.ToString()+"\nThank you for Playing!";
                break;
        }
    }
}
