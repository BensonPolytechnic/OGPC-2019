using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingForce : MonoBehaviour
{

    public float liftConstant = 1.0f;
    public float degree = 2.0f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        GameObject[] wingSurfaces = GameObject.FindGameObjectsWithTag("deflectionSurface");

        foreach (GameObject surface in wingSurfaces)
        {
            rb.AddForceAtPosition(surface.transform.rotation * Vector3.down * Vector3.Dot(rb.GetPointVelocity(surface.transform.position), surface.transform.rotation * Vector3.up) * Mathf.Pow(rb.velocity.magnitude, degree) * surface.transform.localScale.x * surface.transform.localScale.z * liftConstant, surface.transform.position);
        }
    }
}