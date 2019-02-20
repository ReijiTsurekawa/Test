using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMe : MonoBehaviour {
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
         //   Debug.Log("In");
            Vector3 PlayerPos = other.transform.position;
            Vector3 VilusPos = transform.parent.position;

            var aim = VilusPos - PlayerPos;
            var look = Quaternion.LookRotation(aim);



            transform.parent.rotation = look;//Quaternion.Euler(0,deg,0);


        }
    }
}
