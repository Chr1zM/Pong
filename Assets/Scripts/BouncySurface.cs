using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float BounceForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var ball = collision.gameObject.GetComponent<BallMovement>();

        if (ball != null)
        {
            var normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * BounceForce);
        }
    }
}
