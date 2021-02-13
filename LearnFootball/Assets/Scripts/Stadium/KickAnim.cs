using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickAnim : MonoBehaviour
{
    private Animator _animator;
    private BoxCollider _boxCollider;
    private Vector3 _currentSize;
    private Vector3 _kickingSize;


    void Start()
    {
        _animator =GetComponent<Animator>();
        _boxCollider = GetComponent<BoxCollider>();
        _currentSize = new Vector3(1.003f, 1.221f, 0.3f);
        _kickingSize = new Vector3(1.003f, 1.221f, 0.7f);
    }

   
    void FixedUpdate()
    {
        if (_animator.GetCurrentAnimatorStateInfo(0).IsName("Armature|Kick"))
        {
            _boxCollider.size = _kickingSize;
        }
        else
        {
            _boxCollider.size = _currentSize;
        }

        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetBool("kicking", true);
        }
        else
        {
            _animator.SetBool("kicking", false);
        }
        
    }
}

