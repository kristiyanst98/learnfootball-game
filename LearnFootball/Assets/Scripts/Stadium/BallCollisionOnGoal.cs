using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionOnGoal : MonoBehaviour
{
    
    private Vector3 _startPos = new Vector3(0f, -1.2f, 0.3f);
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            transform.position = _startPos;
            _rb.velocity = Vector3.zero;
            _rb.angularVelocity = Vector3.zero;
            
        }
    }

    
}
