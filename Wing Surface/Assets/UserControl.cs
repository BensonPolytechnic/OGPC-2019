using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour {

	// Update is called once per frame
	void FixedUpdate () {
        HingeJoint connection = GetComponent<HingeJoint>();

        JointSpring hingeSpring = connection.spring;

        //float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.E))
        {
            hingeSpring.targetPosition = 0;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            hingeSpring.targetPosition = -30;
        }
        else if (Input.GetKey(KeyCode.E))
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
