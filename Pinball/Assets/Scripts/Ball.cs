using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Finish")
        {
            this.GetComponent<Collider>().enabled = false;
        }
    }
}
