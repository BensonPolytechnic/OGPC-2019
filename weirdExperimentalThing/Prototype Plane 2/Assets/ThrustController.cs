using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustController : MonoBehaviour {

    public float netForce = 100.0f;

    // Update is called once per frame
    void Update()
    {
        ConstantForce force = GetComponent<ConstantForce>();
        Rigidbody rb = GetComponent<Rigidbody>();

        if (Input.GetButton("Fire1"))
        {
            force.relativeForce = new Vector3((2 - 2 / (1 + Mathf.Pow(1.00005f, - Mathf.Pow(rb.velocity.magnitude, 2)))) * netForce, force.relativeForce[1], force.relativeForce[2]);
        }
        else
        {
            force.relativeForce = new Vector3(0.0f, force.relativeForce[1], force.relativeForce[2]);
        }

    }
}
