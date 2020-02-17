﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float verticalVelocity = 0;
    public float movementSpeed = 5;
    public float cameraSpeed = 5;
    public float jumpHeight = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rotate the player object about the Y axis
        //look left and right
        float rotation = Input.GetAxis("Mouse X");
        rotation *= cameraSpeed;
        transform.Rotate(0,rotation,0);

        //rotate the camera (the player's head) about its X axis
        //look up and down
        float updown = Input.GetAxis("Mouse Y");
        updown *= cameraSpeed;
        Camera.main.transform.Rotate(-updown, 0,0);

        //moving forwards and backwards
        float forwardSpeed = Input.GetAxis("Vertical");
        forwardSpeed *= movementSpeed;

        //moving left and right
        float lateralSpeed = Input.GetAxis("Horizontal");
        lateralSpeed *= movementSpeed;

        //apply gravity
        verticalVelocity += Physics.gravity.y * Time.deltaTime;

        CharacterController characterController = GetComponent<CharacterController>();

        if (Input.GetButton("Jump") && characterController.isGrounded){
            verticalVelocity = jumpHeight;
        }

        Vector3 speed = new Vector3(lateralSpeed, verticalVelocity, forwardSpeed);

        //transform speed relative to player rotation to make them move forward, not north
        speed = transform.rotation * speed;

        //move at different speed to make up for variable framerates
        characterController.Move(speed * Time.deltaTime);
    }
}