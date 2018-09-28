using UnityEngine;
using System.IO.Ports;

public class AudrinoCommunication : MonoBehaviour
{
    //Set the port and baud rate
    SerialPort stream = new SerialPort("COM8", 9600);

    int buttonState = 0;

    void Start()
    {
        //Opens the Serial Stream
        stream.Open();
    }

    void Update()
    {
        //Read information from Audrino
        string value = stream.ReadLine();
        buttonState = int.Parse(value);
    }

    void OnGUI()
    {
        string newString = "Connected: " + buttonState;
        //Display the new values
        GUI.Label(new Rect(10, 10, 300, 100), newString);
    }

}
