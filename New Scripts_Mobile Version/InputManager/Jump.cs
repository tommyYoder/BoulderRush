using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {


    public float jumpSpeed = 240f;
    public float forwardSped = 20f;
    public Rigidbody2D body2D;
    public InputState inputState;


    // Update is called once per frame
    // Looks to see if the player is standing and the action button has been pressed. If false, then the player will be able to jump. Jump sounds plays when any button is pressed and the player can jump.
    void Update() {

        if (inputState.standing)
        {
            if (inputState.actionButton)
            {
                body2D.velocity = new Vector2(transform.position.x < 0 ? forwardSped : 0, jumpSpeed);
                GetComponent<AudioSource>().Play();

            }

        }
    }
}
	

