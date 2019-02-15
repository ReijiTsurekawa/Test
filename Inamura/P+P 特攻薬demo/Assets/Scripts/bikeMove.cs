using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bikeMove : MonoBehaviour
{
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
    float speed = 0;
    public int num = 0;
    // Use this for initialization
    void Start()
    {
        GameObject goal = GameObject.Find("goal");
        next_step = STEP.SET;
    }

    // Update is called once per frame
    void FixedUpdate()
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
                if (step_timer > 5.0f)
                {
                    GetComponent<AudioSource>().Play();
                    next_step = STEP.PLAY;
                }
                break;
            case STEP.PLAY:
                if (speed < 0)
                    speed = 0;
                if (Input.GetKey(KeyCode.W))
                {
                    speed = speed + 0.1f;
                }
                else
                {
                    if (speed != 0)
                        speed = speed - 0.1f;
                }
                this.transform.Translate(1f + speed, 0, 0);
                if (Input.GetKey(KeyCode.RightArrow))
                    this.transform.Rotate(new Vector3(0, -1f, 0));
                if (Input.GetKey(KeyCode.LeftArrow))
                    this.transform.Rotate(new Vector3(0, 1f, 0));
                break;
            case STEP.CLEAR:
                Debug.Log("CLEAR");
                num = 1;
                break;
        }
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "goal")
        {
            next_step = STEP.CLEAR;
        }
    }
}

