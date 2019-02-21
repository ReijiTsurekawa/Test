using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_pop : MonoBehaviour
{
    float X = 0.0f;
    float Z = 0.0f;
    public int PPx, MPx;//乱数のやつ
    public int PPz, MPz;
    public int maxCount;
    private int count = 0;

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
                GameObject Enemy = new GameObject("Enemys");
                Vector3 Pos = Ene.transform.position;
                for (int i = 0; i < 3; i++)
                {
                    float Enex = Random.Range(Pos.x + PPx, Pos.x - MPx);
                    float Enez = Random.Range(Pos.z + PPz, Pos.z - MPz);

                    GameObject Set = Instantiate(Ene, new Vector3(Enex, 30.0f, Enez), Quaternion.identity);
                }
                count++;
            }
        }
        Debug.Log("Encount");
    }
}