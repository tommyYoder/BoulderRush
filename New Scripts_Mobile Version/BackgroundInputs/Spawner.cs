using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] prefabs;
    public float delay = 2.0f;

    public bool active = true;
    public Vector2 delayRange = new Vector2(1, 2);

	// Use this for initialization
	void Start () {
        ResetDelay();
        StartCoroutine(EnemyGenerator());
	}

    // After the delay is met this will make the game object spawn in the game.
	IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);

        if (active)
        {
            var newTransform = transform;

            GameObjectUtil.Instantiate(prefabs[Random.Range(0, prefabs.Length)], newTransform.position);
            ResetDelay();
        }
        StartCoroutine(EnemyGenerator());
    }
    // Delays the gameobject in a random range for more or less objects spawned.
    void ResetDelay()
    {
        delay = Random.Range(delayRange.x, delayRange.y);
    }
}
