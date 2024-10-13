using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float walkSpeed = 5f; //variable are written in 'camelCase'
    public float MAX_WALK_SPEED = 0; // constants are written in 'UPPERCASE_SNAKE_CASE'
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rb.velocity = movement * walkSpeed;
    }
}