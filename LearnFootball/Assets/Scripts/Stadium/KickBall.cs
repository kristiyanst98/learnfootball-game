using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickBall : MonoBehaviour
{
    
    private Rigidbody _rb;
    private float _kickingForce=1f;
    private float _reflectForce = 0.6f;
    private Vector3 _direction;
    private Vector3 _reflection;

    public Animator anim;
    public AudioSource kickSound;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player") && anim.GetCurrentAnimatorStateInfo(0).IsName("Armature|Kick"))
        {
            _direction = (this.transform.position - collision.transform.position);
            _direction.Normalize();
            _rb.AddForce(_direction * _kickingForce, ForceMode.Impulse) ;
            kickSound.Play();
        }
        if (collision.collider.CompareTag("Barrier"))
        {
            _reflection = this.transform.position - collision.transform.position;
            _reflection.Normalize();
            _rb.AddForce( _reflection * _reflectForce, ForceMode.Impulse);
        }

       
    }

    
}
