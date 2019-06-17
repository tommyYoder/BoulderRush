using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectUtil  {

    private static Dictionary<RecycleGameobject, ObjectPool> pools = new Dictionary<RecycleGameobject, ObjectPool>();

    // Will instantiate a game object.
    public static GameObject Instantiate(GameObject prefab, Vector3 pos)
    {
        GameObject instance = null;

        var recycledScript = prefab.GetComponent<RecycleGameobject>();

        if (recycledScript != null)
        {
            var pool = GetObjectPool(recycledScript);
            instance = pool.NextObject(pos).gameObject;
        }
        else
        {

            instance = GameObject.Instantiate(prefab);
            instance.transform.position = pos;
        }
        return instance;
    }
    // Will look through the recyclegameobject script to shut down or delete a gameobject.
    public static void Destroy(GameObject gameobject)
    {
        var recycleGameObject = gameobject.GetComponent<RecycleGameobject>();

        if (recycleGameObject != null)
        {
            recycleGameObject.Shutdown();
        }
        else
        {
            GameObject.Destroy(gameobject);
        }
    }

    public static void Reset()
    {
        pools.Clear();
    }

    // Allows the RecycleGameobject script to reuse to save on memory when a new game object is spawned.
    private static ObjectPool GetObjectPool(RecycleGameobject reference)
    {
        ObjectPool pool = null;

        if (pools.ContainsKey(reference))
        {
            pool = pools[reference];
        }else
        {
            var poolContainer = new GameObject(reference.gameObject.name + "ObjectPool");
            pool = poolContainer.AddComponent<ObjectPool>();
            pool.prefab = reference;
            pools.Add(reference, pool);
        }
        return pool;
    }
}
