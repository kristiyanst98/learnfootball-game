using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public Rigidbody ball;
    public Rigidbody player;

    private Vector3 _startPos = new Vector3(0f, -1.2f, 0.3f);

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ball.transform.position = _startPos;
            ball.velocity = Vector3.zero;
            ball.angularVelocity = Vector3.zero;
        }
        if (other.CompareTag("Player"))
        {
            player.transform.position = _startPos;
           
        }
    }
}
