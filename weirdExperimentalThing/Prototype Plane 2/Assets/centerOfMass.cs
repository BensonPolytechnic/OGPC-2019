// Expose center of mass to allow it to be set from
// the inspector.
using UnityEngine;
using System.Collections;

public class centerOfMass : MonoBehaviour
{
    public Vector3 com;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.centerOfMass = com;
    }
}