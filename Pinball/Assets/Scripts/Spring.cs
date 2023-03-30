using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spring : MonoBehaviour
{
    [SerializeField] private float minPower = 0;
    [SerializeField] private float maxPower = 100;
    [SerializeField] private float addPower = 1000;
    private Rigidbody _ball;
    public bool ready;
    
    private float _power;
    

    void Start()
    {
        
    }

    void Update()
    {
        Fire();
    }

    
    
    
    private void Fire()
    {
        if (_ball != null)
        {
            ready = true;

            if (Input.GetKey(KeyCode.Space))
            {
                if (_power <= maxPower)
                {
                    _power += addPower * Time.deltaTime;
                }
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                _ball.AddForce(_power * Vector3.left);
            }
        }
        else
        {
            ready = false;
            _power = minPower;
        }
    }
    
    
    
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _ball = other.gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            _ball = null;
            _power = minPower;
        }
    }
}
