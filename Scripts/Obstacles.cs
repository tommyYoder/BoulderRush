using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour, IRecycle {

    public Sprite[] sprites;

    public Vector2 colliderOffset = Vector2.zero;

    // Will generate a random sprite when the game object is instantiaed. The collider will size correctly on each sprite.
    public void Restart()
    {
        var renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = sprites[Random.Range(0, sprites.Length)];

        var collider = GetComponent<BoxCollider2D>();
        var size = renderer.bounds.size;
        size.y += colliderOffset.y;

        collider.size = size;
        collider.offset = new Vector2(-colliderOffset.x, collider.size.y / 2 -colliderOffset.y);

    }
    // Just need to add this line in for the IRecycle to work.
    public void Shutdown()
    {

    }
}
