using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class angularDraginator : MonoBehaviour {

    public float velocityMultipler = 1.0f;
    public float degree = 1.0f;
	
	// Update is called once per frame
	void Update () {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.angularDrag = Mathf.Pow(rb.velocity.magnitude * rb.angularVelocity.magnitude, degree) * velocityMultipler;
	}
}
