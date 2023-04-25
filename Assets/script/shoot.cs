using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject ballPrefab; // Ball prefab to be instantiated
    public float ballSpeed = 10.0f; // Speed of the ball
    public int damageAmount = 20; // Damage amount of the ball

    // Update is called once per frame
    void Update()
    {
        // Check if the player has pressed the fire button (left mouse button)
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate a new ball game object
            GameObject ball = Instantiate(ballPrefab, transform.position, Quaternion.identity);

            // Get the rigidbody component of the ball game object
            Rigidbody2D ballRigidbody = ball.GetComponent<Rigidbody2D>();

            // Calculate the direction of the ball towards the mouse position
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (mousePosition - (Vector2)transform.position).normalized;

            // Set the velocity of the ball to the direction and speed
            ballRigidbody.velocity = direction * ballSpeed * 4;
        }
    }

    
   
}