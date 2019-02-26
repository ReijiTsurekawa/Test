using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class time : MonoBehaviour
{
    public Text timerText;
    public Text Fin;

    public float totalTime;
    int seconds;
    public int num = 0;

  /*  // Update is called once per frame
    void Update()
    {

        if (seconds < 0.0f)
        {
            if (seconds > 5.0f)
            {
                SceneManager.LoadScene("End");
            }
        }

    }
    */
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
    private float step_timer = 0.0f;   // 経過時間を入れる.

    void Start()
    {
        next_step = STEP.SET;    // 最初はSETから.
        Fin.GetComponent<Text>().enabled = false;
    }

    void Update()
    {
        step_timer += Time.deltaTime;    // 経過時間を取得.

        if (next_step != STEP.NONE)
        {
            step = next_step;            // 現状に反映.
            next_step = STEP.NONE;        // 次のSTEPは変化待ち状態に.
            step_timer = 3.0f;            // stepが変化したら時間リセット.
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
                totalTime -= Time.deltaTime;
                seconds = (int)totalTime;
                timerText.text ="Time:" +seconds.ToString();
                //Debug.Log("Play終わり");
                if (seconds==0)
                {
                    next_step = STEP.CLEAR;
                }
                break;
            case STEP.CLEAR:
                Debug.Log("クリア");
                num = 1;
                Fin.GetComponent<Text>().enabled = true;
                if (step_timer > 5.0f)
                {
                    SceneManager.LoadScene("result");
                }
                break;
        }

    }
 
}