using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("pocket"))
    //    {
    //        this.gameObject.SetActive(false);
    //    }
    //}

    void OnCollisionEnter (Collision targetObj)
    {
        if(targetObj.gameObject.tag == "pocket")
        {
          this.gameObject.SetActive(false);  
        }
    }

}
