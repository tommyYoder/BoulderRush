using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScreen : MonoBehaviour {

    public float offset = 16f;
    public delegate void OnDestroy();
    public event OnDestroy DestroyCallBack;


    private bool offscreen;
    private float offscreenX = 0f;
    public Rigidbody2D body2D;

    // Use this for initialization
    void Start () {
        // Looks for the screen width of the camera to offset the gameobject in the X direction.
        offscreenX = (Screen.width / PixelPerfectCamera.pixelesToUnits) / 2 + offset;
	}
	
	// Update is called once per frame
	void Update () {

        // Looks for the position and direction of the game objects to see if it is offscreen or not. 
        var posX = transform.position.x;
        var dirX = body2D.velocity.x;

        if (Mathf.Abs(posX) > offscreenX)
        {
            if (dirX < 0 && posX < -offscreenX)
            {
                offscreen = true;
            }
            else if (dirX > 0 && posX > offscreenX)
            {
                offscreen = true;
            }
        }else
        {
            offscreen = false;
        }
        if (offscreen)
        {
            OnOutOfBounds();
        }

    }
    // If the game object is out of bounds then the game object is destroyed.
    public void OnOutOfBounds()
    {
        offscreen = false;
       GameObjectUtil.Destroy(gameObject);

        if (DestroyCallBack != null)
        {
            DestroyCallBack();
        }
    }
}

