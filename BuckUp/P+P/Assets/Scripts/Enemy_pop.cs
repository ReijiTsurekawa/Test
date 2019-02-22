using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_pop : MonoBehaviour
{
    float Enex;
    float Enez;
    public int xPlus, xMinus;//乱数のやつ
    public int zPlus, zMinus;
    public int maxCount;
    private int count = 0;
    Vector3 Pos;

    public GameObject Ene;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (count <= maxCount)
        {
            //　プレイヤーキャラクターを発見
            if (col.tag == "Player")
            {
               // GameObject Enemy = new GameObject("Enemys");
                Pos = this.transform.position;
                for (int i = 0; i < 3; i++)
                {
                    Enex = Random.Range(Pos.x + xPlus, Pos.x - xMinus);
                    Enez = Random.Range(Pos.z + zPlus, Pos.z - zMinus);

                    GameObject Set = Instantiate(Ene, new Vector3(Enex, 10.0f, Enez), Quaternion.identity);
                    Debug.Log(Enex);
                    Debug.Log(Enez);
                }
                count++;
            }
        }
        //Debug.Log("Encount");
    }
}