using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    protected Rigidbody2D _rb;

    public float Speed = 10f;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        _rb.position = new Vector2(_rb.position.x, 0);
        _rb.velocity = Vector2.zero;
    }
}
