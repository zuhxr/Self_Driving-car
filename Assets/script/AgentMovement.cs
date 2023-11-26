using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoWheeledAgentMovement : MonoBehaviour
{
    public float moveSpeed = 5f;   // Speed of the agent
    public float rotationSpeed = 100f;   // Rotation speed of the agent

    void Update()
    {
        // Move forward or backward based on user input
        float moveInput = Input.GetAxis("Vertical");
        float moveAmount = moveInput * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveAmount);

        // Rotate left or right based on user input
        float rotationInput = Input.GetAxis("Horizontal");
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * rotationAmount);
    }
}
