using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wingSurfaceInitializer : MonoBehaviour {
    public float forceMultipler = 0.0f;
    public string userControl = "None";

    public float getLift ()
    {
        return forceMultipler;
    }

    public string getControl ()
    {
        return userControl;
    }
}
