using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustController : MonoBehaviour {

    public float netForce = 100.0f;
	
	// Update is called once per frame
	void Update () {
		Rigidbody rb = GetComponent<Rigidbody>();
        ConstantForce force = GetComponent<ConstantForce>();
        if (Input.GetKey(KeyCode.LeftShift))
        {
            force.relativeForce = new Vector3(netForce, 0.0f, 0.0f);
        }
        else
        {
            force.relativeForce = new Vector3(0.0f, 0.0f, 0.0f);
        }
        
	}
}
