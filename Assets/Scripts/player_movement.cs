using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public float Speed = 1f;
    public float MaxSpeed = 3f;
    public float MinSpeed = 1f;
    public float Acceleration = 2f;
    public float Deceleration = 5f;


    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Speed = Mathf.Min(Speed + Acceleration * Time.deltaTime, MaxSpeed);

        }
        else
        {
            Speed = Mathf.Max(Speed - Deceleration * Time.deltaTime, MinSpeed);
        }

    }

    Rigidbody2D body;

    float horizontal;
    float vertical;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * Speed, vertical * Speed);
    }




}