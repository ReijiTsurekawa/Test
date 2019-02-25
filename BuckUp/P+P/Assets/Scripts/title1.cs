
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class title1 : MonoBehaviour {
    public Text text;
    private float timer = 0.0f;
    private STEP step;          // 今のSTEP.
    private STEP next_step;     // 次のSTEP.
    private float step_timer;
    public enum STEP
    {            // 状況STEP作成.
        NONE = -1,
        SET,
        START,
        PLAY,
        CLEAR,
    }
    void Start() {
        text.color = new Color(0, 0, 0);
        next_step = STEP.SET;
    }
    void Update() {
        timer += Time.deltaTime;
        var color = text.color;
        color.a = Mathf.Sin(timer*2.0f) * 0.5f + 0.5f;
        text.color = color;
        if (Input.GetKeyDown("w"))
        {
            SceneManager.LoadScene("Test2");
        }
      
    } 
}






