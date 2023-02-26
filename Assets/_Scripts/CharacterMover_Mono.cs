using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover_Mono : MonoBehaviour
{
    // References
    private Rigidbody rb;
    
    // Inspector References
    [SerializeField] private float moveSpeed;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        // Keyboard Movement
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, rb.velocity.y, Input.GetAxis("Vertical") * moveSpeed); // Todo: Normalize so that it doesn't move faster diagonally
    }

    private void HandleMouseCamera()
    {
        
    }
}
