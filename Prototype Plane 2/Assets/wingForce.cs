using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingForce : MonoBehaviour {

    public float forceMultipler = 5.0f;
    public float degree = 2.0f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        //ConstantForce force = GetComponent<ConstantForce>();
        //force.relativeForce = new Vector3(force.relativeForce.x, Vector3.Dot(rb.velocity.normalized, rb.rotation * Vector3.down) * Mathf.Pow(rb.velocity.magnitude, degree) * forceMultipler, force.relativeForce.z);
        rb.AddRelativeForce(Vector3.up * Vector3.Dot(rb.velocity.normalized, rb.rotation * Vector3.down) * Mathf.Pow(rb.velocity.magnitude, degree) * forceMultipler);
    }

}