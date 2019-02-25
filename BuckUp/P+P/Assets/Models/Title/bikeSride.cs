using UnityEngine; 
 using System.Collections;


public class bikeSride : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed =1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        GameObject text = GameObject.Find("Text");
        if (text.GetComponent<title>().next != 2.0f)
        {
            if (text.GetComponent<title>().next > 0.0f)
            {
                rb.velocity = new Vector2(moveSpeed*0.0008f, rb.velocity.y);
            }

        }
    }
}
