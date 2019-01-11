using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour {

    public string controlType = "Vertical";
    public float xMultiplier = 0.0f;
    public float yMultiplier = 0.0f;
    public float zMultiplier = 0.0f;
    public float wIdentity = 1.0f;
    public Quaternion axis = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);


    // Update is called once per frame
    void FixedUpdate()
    {
        Input.GetAxis(controlType);
        transform.localRotation = new Quaternion(xMultiplier * Input.GetAxis(controlType) + axis.x, yMultiplier * Input.GetAxis(controlType) + axis.y, zMultiplier * Input.GetAxis(controlType) + axis.z, wIdentity);
    }
}
