using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;				// オマジナイ.
using UnityEngine.SceneManagement;	// オマジナイ.

public class timer : MonoBehaviour
{
    public enum STEP
    {            // 状況STEP作成.
        NONE = -1,
        SET,
        START,
        PLAY,
        CLEAR,      // クリア.

    }
    private STEP step;          // 今のSTEP.
    private STEP next_step;     // 次のSTEP.
    private float step_timer=0.0f;   // 経過時間を入れる.
    private float time=0;
    public Text timer_text;     // UIテキスト.
    void Start()
    {
        next_step = STEP.SET;    // 最初はSETから.
    }

    void Update()
    {
        step_timer += Time.deltaTime;    // 経過時間を取得.

        if (next_step != STEP.NONE)
        {
            step = next_step;            // 現状に反映.
            next_step = STEP.NONE;        // 次のSTEPは変化待ち状態に.
            step_timer = 0.0f;            // stepが変化したら時間リセット.
            switch (step)
            {
                case STEP.SET:
                    next_step = STEP.START;
                    break;
            }
        }

        // （２）ステップ中繰り返し実行する所.
        switch (step)
        {
            case STEP.START:
                if (step_timer > 5.0f)
                {
                        next_step = STEP.PLAY;
                }
                break;
            case STEP.PLAY:
                time = (time + Time.deltaTime);
                int times = (int)time;
                timer_text.text ="Time:"+times.ToString();
                GameObject bike = GameObject.Find("Bike");
                if (bike.GetComponent<bikeMove>().num == 1)
                {
                    next_step = STEP.CLEAR;
                }
                break;
            case STEP.CLEAR:
                timer_text.text =timer_text.text;
                if (step_timer > 5.0f)
                {
                    SceneManager.LoadScene("title");
                }
                break;
        }
    }
}