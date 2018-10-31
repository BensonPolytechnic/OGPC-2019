using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class Arduino_Interface : MonoBehaviour {
    SerialPort serial_1 = new SerialPort("COM4", 9600);

    bool servo_mode = true;


    public void Update()
    {


        if (servo_mode == false)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                servo_mode = true;
            }
        }

        if (servo_mode == true)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                servo_mode = false;
            }
        }

        if (servo_mode)
        {
            send_xroll();
        }
    }

    public void send_xroll()
    {
        float roll = transform.localEulerAngles.x;
        int roll_int = (int) roll;
        if (roll_int < 0)
            roll_int = Mathf.Abs(roll_int);
        serial_1.Open();
        serial_1.Write(roll_int.ToString());
        System.Threading.Thread.Sleep(1);
        serial_1.Close();
        Debug.Log("Wrote data to arduino %s");
    }
}
