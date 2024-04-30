using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D _rb;

    public float SpeedX = 400.0f;
    public float SpeedY = 400.0f;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        AddStartingForce();
    }

    public void AddStartingForce()
    {
        var x = Random.value < 0.5f ? -1.0f : 1.0f;
        var y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        _rb.AddForce(new Vector2(x * SpeedX, y * SpeedY));
    }

    public void AddForce(Vector2 force)
    {
        _rb.AddForce(force);
    }

    public void ResetPosition()
    {
        _rb.position = Vector2.zero;
        _rb.velocity = Vector2.zero;
    }
}
