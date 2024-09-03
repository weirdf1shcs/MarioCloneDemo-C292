using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMover : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] private Rigidbody2D rb;
    private float frameCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        MoveLeft();
        
    }

    private void FixedUpdate()
    {
        if (frameCount < 120)
        {
            frameCount++;
        }
        else
        {
            Jump();
            frameCount = 0;
        }
    }

    void MoveLeft()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
    }
    private void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
