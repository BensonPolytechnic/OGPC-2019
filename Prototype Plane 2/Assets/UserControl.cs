﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour {

    public float pitchTrim = 0.0f;
    public float yawTrim = 0.0f;
    public float rollTrim = 0.0f;
    public float pitchDeflection = 5.0f;
    public float yawDeflection = 20.0f;
    public float rollDeflection = 2.5f;

    // Update is called once per frame
    void FixedUpdate()
    {
        HingeJoint[] connections = GetComponents<HingeJoint>();

        foreach (HingeJoint joint in connections)
        {
            JointSpring surfaceSpring = joint.spring;

            if (joint.connectedBody.CompareTag("Lroll"))
            {
                
                surfaceSpring.targetPosition = -rollDeflection * Input.GetAxis("Horizontal") - rollTrim;
                
            }
            else if (joint.connectedBody.CompareTag("Rroll"))
            {

                surfaceSpring.targetPosition = rollDeflection * Input.GetAxis("Horizontal") + rollTrim;

            }
            else if (joint.connectedBody.CompareTag("pitch"))
            {

                surfaceSpring.targetPosition = -pitchDeflection * Input.GetAxis("Vertical") + pitchTrim;

            }
            else if (joint.connectedBody.CompareTag("yaw"))
            {

                surfaceSpring.targetPosition = yawDeflection * Input.GetAxis("Yaw") + yawTrim;

            };

            joint.spring = surfaceSpring;
        }
    }
}
