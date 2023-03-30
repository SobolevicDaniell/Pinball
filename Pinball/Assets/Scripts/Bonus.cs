using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    [SerializeField] private int cost;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Score.Instance.AddScore(cost);
        }
    }
}
