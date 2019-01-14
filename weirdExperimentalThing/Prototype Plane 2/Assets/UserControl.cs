using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControl : MonoBehaviour {

    public string controlType = "Vertical";
    public Vector3 axis = new Vector3(0.0f, 0.0f, 0.0f);
    public Vector3 gimbal = new Vector3(0.0f, 0.0f, 0.0f);


    // Update is called once per frame
    void FixedUpdate()
    {
        Input.GetAxis(controlType);
        transform.localEulerAngles = new Vector3(gimbal.x * Input.GetAxis(controlType) + axis.x, gimbal.y * Input.GetAxis(controlType) + axis.y, gimbal.z * Input.GetAxis(controlType) + axis.z);
    }
}
