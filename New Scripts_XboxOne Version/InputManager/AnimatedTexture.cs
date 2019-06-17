using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedTexture : MonoBehaviour {

    public Vector2 speed = Vector2.zero;
    private Vector2 offset = Vector2.zero;
    public Material material;

	// Gets the materials components including the offset.
	void Start () {
        material = GetComponent<Renderer>().material;

        offset = material.GetTextureOffset("_MainTex");
	}
	
	// Updates the material's offset to allow the material to move. 
	void Update () {
        offset += speed * Time.deltaTime;

        material.SetTextureOffset("_MainTex", offset);
	}
}
