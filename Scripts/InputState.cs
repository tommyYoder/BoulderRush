using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputState : MonoBehaviour {

    public bool actionButton;
    public float AbsVelX = 0f;
    public float AbsVelY = 0f;
    public bool standing;
    public bool jumping;
    public float standingThreshold = 1f;
    public float jumpingThreshold = 1f;
    private Rigidbody2D body2D;

     void Awake()
    {
        body2D = GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
    // Press any button to activate any command.
	void Update () {
        actionButton = Input.anyKeyDown;
	}
    // Looks for the absolute value of x and y to make them positive. Will look to see if they player is standing or not plus if the player is jumping or not.
     void FixedUpdate()
    {
        AbsVelX = System.Math.Abs(body2D.velocity.x);
        AbsVelY = System.Math.Abs(body2D.velocity.y);

        standing = AbsVelY <= standingThreshold;
        jumping = AbsVelY >= jumpingThreshold;
    }
}
