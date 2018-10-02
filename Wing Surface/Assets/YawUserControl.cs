using System.Collections;
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

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.D))
        {
            hingeSpring.targetPosition = 0;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            hingeSpring.targetPosition = -15;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            hingeSpring.targetPosition = 15;
        }
        else
        {
            hingeSpring.targetPosition = 0;
        }

        connection.spring = hingeSpring;
    }
}
