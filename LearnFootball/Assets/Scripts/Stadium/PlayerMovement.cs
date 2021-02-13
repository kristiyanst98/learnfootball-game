using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed;
    public Animator animator;
    void Start()
    {
        animator=GetComponent<Animator>();
        
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(horizontalInput, 0, 0) * _moveSpeed * Time.deltaTime);
        
        transform.Translate(new Vector3(0, 0, verticalInput) * _moveSpeed * Time.deltaTime);
        if (horizontalInput > 0.0001f || horizontalInput < 0)
        {
            animator.SetFloat("Speed", horizontalInput);
            animator.SetBool("notMoving", false);
        }

        else if (verticalInput > 0.0001f || verticalInput < 0)
        {
            animator.SetFloat("Speed", verticalInput);
            animator.SetBool("notMoving", false);
        }
        else
        {
            animator.SetBool("notMoving", true);
            animator.SetFloat("Speed", 0);
        }
    }
}
