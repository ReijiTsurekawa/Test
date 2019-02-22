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


    float speedPower = 0;//加速の大きさ
    float bikeLean = 0;

    public float sppedMax;
    public float error;

    Vector3 move = new Vector3(0.0f, 0.0f, 0);
    float rotate = 0;

    public int num = 0;

    float ViveY;
    public bool Vive = false;

    int abc = 0;

    // Use this for initialization
    void Start()
    {
        rotate = 0;
        GameObject goal = GameObject.Find("goal");
        next_step = STEP.SET;


    }

    void Update()
    {
        float y = this.GetComponent<InputVive>().Vive_Y_get();
        //Debug.Log(y);
        if (Vive == false)
        {
            ViveFalse();
        }
        else
        {
            ViveTrue();
        }
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

                Play();
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

    void Play()
    {


        float deg = (rotate / 360) * Mathf.PI * 2;

        move.x = speedPower * Mathf.Cos(deg);
        move.z = (-1) * speedPower * Mathf.Sin(deg);

        Rigidbody RB =this.GetComponent<Rigidbody>();

        
        RB.AddForce(sppedMax * (move - RB.velocity));

        //RB.AddForce(move);
        //Debug.Log(move);
        //Debug.Log(speedPower);

        this.transform.rotation = Quaternion.Euler(bikeLean, rotate, 0);
    }

    void ViveTrue()
    {
        float y = this.GetComponent<InputVive>().Vive_Y_get();
        Debug.Log(y);
        if (Input.anyKey)//↑が押されているとき
        {
            speedPower = speedPower + 1f;//加速を上げる
            abc++;
            if (speedPower >= 100)
            {
                speedPower = 100;
            }
            // Debug.Log(abc + ":" + y);
        }
        else
        {
            if (speedPower != 0)
                speedPower = speedPower - 1f;//加速を下げる
        }

        if (y > error)
        {
            rotate += Mathf.Abs(y * 10);
            bikeLean--;
            if (bikeLean < -10)
                bikeLean = -10;
        }
        else if (y < -error)
        {
            rotate -= Mathf.Abs(y * 10);
            bikeLean++;
            if (bikeLean > 10)
                bikeLean = 10;
        }
        else
        {
            if (bikeLean != 0)
            {
                if (bikeLean > 0)
                    bikeLean--;
                else
                    bikeLean++;
            }
            else
            {
                bikeLean = 0;
            }
        }

    }

    void ViveFalse()
    {
        if (Input.GetKey(KeyCode.UpArrow))//↑が押されているとき
        {
            speedPower = speedPower + 1f;//加速を上げる
            if (speedPower >= 100)
            {
                speedPower = 100;
            }
        }
        else
        {
            if (speedPower != 0)
                speedPower = speedPower - 1f;//加速を下げる
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotate += 2f;
            bikeLean--;
            if (bikeLean < -15)
                bikeLean = -15;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            rotate -= 2f;
            bikeLean++;
            if (bikeLean > 15)
                bikeLean = 15;
        }
        else
        {
            if (bikeLean != 0)
            {
                if (bikeLean > 0)
                    bikeLean--;
                else
                    bikeLean++;
            }
            else
            {
                bikeLean = 0;
            }
        }
    }

}



