using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : PaddleMovement
{
    private Vector2 _dir;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) _dir = Vector2.up;
        else if (Input.GetKey(KeyCode.S)) _dir = Vector2.down;
        else _dir = Vector2.zero;
    }

    private void FixedUpdate()
    {
        if (_dir != Vector2.zero) _rb.velocity = _dir * Speed;
        else _rb.velocity = Vector2.zero;
    }
}
