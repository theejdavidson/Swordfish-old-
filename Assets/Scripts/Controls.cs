using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Controls : MonoBehaviour
{
    public float playerSpeed = 10f;
    public float RotateSpeed;
    public int groundMask;
    public Rigidbody rb;
    public Vector3 movement;
    public Vector3 playerVelocity;
    private Camera mainCamera;
    // Use this for initialization
    void Awake()
    {
        groundMask = LayerMask.GetMask("Ground");
        RotateSpeed = 200;
        rb = GetComponent<Rigidbody>(); //maps rigidbody to player
        mainCamera = FindObjectOfType<Camera>(); //maps camera controls to main camera in game
    }
    // Update is called once per physics update
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);

        if (Input.GetMouseButton(0))//tracks left click mouse button
        {
            transform.Rotate(-Vector3.up * (RotateSpeed * Time.deltaTime));
            if (RotateSpeed < 2000)
                RotateSpeed += 2;
        }
        else if (Input.GetMouseButton(1))
        {
            transform.Rotate(Vector3.up * (RotateSpeed * Time.deltaTime));
            if (RotateSpeed < 2000)
                RotateSpeed += 2;
        }
        else if (Input.GetMouseButton(0) == false && Input.GetMouseButton(1) == false)
            RotateSpeed = 200;

        //rb.AddForce(thrust, 0, thrust, ForceMode.Acceleration);
    }
    void Move (float h, float v)
    {
        movement.Set(h, 0f, v);

        movement = movement.normalized * playerSpeed * Time.deltaTime;

        rb.MovePosition(transform.position + movement);
    }

    public float getRSpeed()
    {
        return RotateSpeed;
    }
}