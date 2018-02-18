using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationManager : MonoBehaviour {

    private Animator animator;
    public InputState inputState;


    // Use this for initialization
    void Awake() {
        animator = GetComponent<Animator>();
        inputState = GetComponent<InputState>();
        ChangeAnimation(0);
    }

    // Update is called once per frame
    // Updates the animation on the player to idel, jumping, or running depending on the player state and int values.
    void Update()
    {
        // Goes to the run animation.
        if(inputState.AbsVelX == 0)
        {
            ChangeAnimation(0);
        }
        // Goes to idle animation when standing on an obstacle.
        if (inputState.AbsVelX > 0 && inputState.AbsVelY < inputState.standingThreshold)
        { 
            ChangeAnimation(1);
         }
        // Goes to the jump animation when any button is pressed.
        if (inputState.AbsVelY > inputState.jumpingThreshold)
        {

            ChangeAnimation(2);
     }
       
 }
    // Allows the animations to change depending on the value set in the animator.
    void ChangeAnimation(int value)
    {
        animator.SetInteger("AnimState", value);
    }
   
}
