using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
    // movespeed = how fast player moves forward and backward
    // rotatespeed = how fast player rotates left and right
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;

    // vInput = vertical axis input
    // hInput = horizontal axis input
    private float vInput;
    private float hInput;

    private Rigidbody _rb;

    void Start() {
        // checks if the game object has a Rigidbody component & returns it
        _rb = GetComponent<Rigidbody>();
    }

    void Update() {
        // moves forward/positive if W or up key is pressed
        // moves backward/negative if S or down key is pressed
        vInput = Input.GetAxis("Vertical") * moveSpeed;

        // rotates right if D or right key is pressed
        // rotates left if A or left key is pressed
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        /* 
        // move the player according to computed direction & speed
        this.transform.Translate(Vector3.forward * vInput * 
        Time.deltaTime);
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
        */
    }
    // rigidbody/physics related code goes inside FixedUpdate b/c it's frame rate independent
    void FixedUpdate(){
        // store left & right rotation as a vector
        Vector3 rotation = Vector3.up * hInput;

        // transform the vector into Euler angle
        Quaternion angleRot = Quaternion.Euler(rotation *
            Time.fixedDeltaTime);

        _rb.MovePosition(this.transform.position +
            this.transform.forward * vInput * Time.fixedDeltaTime);

        // multiply the current rotation by the angle rotation from keyboard
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
} 
