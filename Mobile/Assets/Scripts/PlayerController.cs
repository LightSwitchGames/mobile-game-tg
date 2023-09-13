using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]private float jumpForce;
    [SerializeField] private GameObject groundCheck;
    private bool isGrounded = true;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {

        if(isGrounded == true)
        {
            if (Input.touchCount > 0 || Input.anyKey)
            {
                rb.velocity = Vector3.up * jumpForce;
            }
        }
    }
}
