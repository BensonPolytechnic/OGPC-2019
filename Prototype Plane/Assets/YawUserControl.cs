﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YawUserControl : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        HingeJoint connection = GetComponent<HingeJoint>();

        JointSpring hingeSpring = connection.spring;

        //float verticalInput = Input.GetAxis("Vertical");

        hingeSpring.targetPosition = -15 * (Input.GetAxis("LTrigger") + Input.GetAxis("RTrigger"));

        connection.spring = hingeSpring;
    }
}
