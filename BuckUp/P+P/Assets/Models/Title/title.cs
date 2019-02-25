
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class title : MonoBehaviour
{
    public Text text;
    private float timer = 0.0f;
    public float next = 2.0f;
    private STEP step;          // 今のSTEP.
    private STEP next_step;     // 次のSTEP.
    private float step_timer;
    int num = 0;
    int num2 = 0;
    public enum STEP
    {            // 状況STEP作成.
        NONE = -1,
        SET,
        START,
        PLAY,
        CLEAR,
    }
    void Start()
    {
        text.color = new Color(0, 0, 0);
        next_step = STEP.SET;
    }
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            num = 1;
            GameObject BikeEngine = GameObject.Find("BikeEngine");
            BikeEngine.GetComponent<AudioSource>().Play();
        }
        if (num == 1)
        {
            text.color = new Color(0, 0, 0, 0);
            next = next - Time.deltaTime;
                        if (next <= 0.0f)
            {
                SceneManager.LoadScene("Main");
            }
        }
        if (num == 0)
        {
            timer += Time.deltaTime;
            var color = text.color;
            color.a = Mathf.Sin(timer * 2.0f) * 0.5f + 0.5f;
            text.color = color;
        }

    }
}