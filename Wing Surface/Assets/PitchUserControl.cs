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

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.S))
        {
            hingeSpring.targetPosition = 0;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            hingeSpring.targetPosition = -30;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            hingeSpring.targetPosition = 30;
        }
        else
        {
            hingeSpring.targetPosition = 0;
        }

        connection.spring = hingeSpring;
    }
}
