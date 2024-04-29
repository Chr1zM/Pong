using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyKiRightMovement : PaddleMovement
{
    private Rigidbody2D _ball;

    private void Start()
    {
        _ball = GameObject.Find("Ball").GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (_ball.velocity.x > 0)
        {
            if (_ball.position.y > transform.position.y) _rb.AddForce(Vector2.up * Speed);
            else if (_ball.position.y < transform.position.y) _rb.AddForce(Vector2.down * Speed);
        }
        else
        {
            if (transform.position.y > 0) _rb.AddForce(Vector2.down * Speed);
            else if (transform.position.y < 0) _rb.AddForce(Vector2.up * Speed);
        }
    }
}
