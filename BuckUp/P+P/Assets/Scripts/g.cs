using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class g : MonoBehaviour
{
    float x = 0.0f;
    float y = 0.0f;
    float z = 0.0f;

    void start()
    {
    }
    void Update()
    {
        Vector3 pos = this.transform.position;
        if (pos.y == 5.0f)
        {
            y = 0.0f;
        }
        else if (pos.y <= 5.0f) {
            y = 9.8f;
        }else
        {
            y = -9.8f;
        }

        if (pos.x == 0.0f)
        {
            x = 0.0f;
        }
        else if (pos.x > 0.0f)
        {
            x=-9.8f;
        }else if (pos.x < 0.0f)
        {
            x = 9.8f;
        }

        if (pos.z == 0.0f)
        {
            z = 0.0f;
        }
        else if (pos.z > 0.0f)
        {
            z = -9.8f;
        }
        else if (pos.z < 0.0f)
        {
            z = 9.8f;
        }

        Physics.gravity = new Vector3(x*10, y*10, z*10);
      
    }
}