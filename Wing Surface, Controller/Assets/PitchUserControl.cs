using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchUserControl : MonoBehaviour
{

    // Update is called once per frame
    void FixedUpdate()
    {
        HingeJoint connection = GetComponent<HingeJoint>();

        JointSpring hingeSpring = connection.spring;

        //float verticalInput = Input.GetAxis("Vertical");

        hingeSpring.targetPosition = 30 * Input.GetAxis("Vertical") * (-1);

        connection.spring = hingeSpring;
    }
}
