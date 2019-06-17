using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantVelocity : MonoBehaviour {

    public Vector2 velocity = Vector2.zero;

    public Rigidbody2D body2D;

     void FixedUpdate()
    {
        body2D.velocity = velocity;
    }
}
