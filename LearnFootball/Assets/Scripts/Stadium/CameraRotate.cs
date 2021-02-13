using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float mouseSpeed = 5;
    public Transform player;
    public Camera yourCam;
    private float Y;
    private float X;

    void Update()
    {
        X = Input.GetAxis("Mouse X") * mouseSpeed;
        Y =Input.GetAxis("Mouse Y") * mouseSpeed;

        player.Rotate(0, X, 0);

        if (yourCam.transform.eulerAngles.x + (-Y) > 80 && yourCam.transform.eulerAngles.x + (-Y) < 280)
        { }
        else
        {
            yourCam.transform.RotateAround(player.position, yourCam.transform.right, -Y);
        }

    }
}