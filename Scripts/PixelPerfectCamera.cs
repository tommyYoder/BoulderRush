using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {


    public static float pixelesToUnits = 1f;
    public static float scale = 1f;

    public Vector2 nativeResolution = new Vector2(240, 160);

    //Sets the camera's resolution in pixels for all resolution types.
	void Awake () {
        var camera = GetComponent<Camera>();

        if (camera.orthographic)
        {
            scale = Screen.height / nativeResolution.y;
            pixelesToUnits *= scale;
            camera.orthographicSize = (Screen.height / 2.0f) / pixelesToUnits;
        }
	}
	

}
