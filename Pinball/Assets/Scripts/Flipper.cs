using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{

    [SerializeField] private float defPos = 0f;
    [SerializeField] private float pressedPos = 40f;
    [SerializeField] private float strength = 10000f;
    [SerializeField] private float damp = 100f;
    [SerializeField] private bool right;

    private HingeJoint _joint;
    private JointSpring _spring;
    
    void Start()
    {
        _joint = GetComponent<HingeJoint>();
        _joint.useSpring = true;

        _spring = new JointSpring();
    }

    void Update()
    {
        _spring.spring = strength;
        _spring.damper = damp;

        if ((Input.GetKey(KeyCode.X) && right) || (Input.GetKey(KeyCode.Z) && !right))
        {
            _spring.targetPosition = pressedPos;
        }
        else
        {
            _spring.targetPosition = defPos;
        }

        _joint.spring = _spring;
    }
}
