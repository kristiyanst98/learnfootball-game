using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotateLockerRoom : MonoBehaviour
{
    [SerializeField]
    private float _mouseSpeed = 5;

    public Transform player;
    public Camera yourCam;

    void Update()
    {
        float X = Input.GetAxis("Mouse X") * _mouseSpeed;
        player.Rotate(0, X, 0);
    }
}

