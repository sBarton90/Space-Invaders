using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] GameObject laser;

    Rigidbody2D myRigidbody;
    Vector2 moveInput;
    float timer = 0;
    float fireRate = .5f;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>(); // Cache a reference to our own rigibody.
    }

    void FixedUpdate()
    {
        MovePlayer();
        timer += Time.deltaTime;
    }

    void OnMove(InputValue value) { // When pressing the move key
        moveInput = value.Get<Vector2>(); // Get the InputValue value and assign to moveInput
    }

    void OnFire(InputValue value) {
        if (value.isPressed && timer >= fireRate) {
            Instantiate(laser, myRigidbody.position, Quaternion.identity);
            timer = 0;
        }
        
    }

    void MovePlayer() { // Method for moving the player during update.
        myRigidbody.velocity = new Vector2(moveInput.x * moveSpeed, myRigidbody.velocity.y); // Set rbody velocity = to keyboard input * speed.
    }

}
