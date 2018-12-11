using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpsCounter : MonoBehaviour {

    float lastFrameTime = 0.0f;
    float currentFrameTime = 0.0f;

    // Use this for initialization
    void Start () {
        Application.targetFrameRate = 90;
    }
	
	// Update is called once per frame
	void Update () {
        lastFrameTime = currentFrameTime;
        currentFrameTime = Time.deltaTime;
	}

    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(0, 0, 0);
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 100), (2 / (lastFrameTime + currentFrameTime)).ToString());
    }
}
