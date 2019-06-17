using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {


    public RecycleGameobject prefab;

    private List<RecycleGameobject> poolInstances = new List<RecycleGameobject>();

    // Will create a instance of the gameobject.
    private RecycleGameobject CreateInstance (Vector3 pos)
    {
        var clone = GameObject.Instantiate(prefab);
        clone.transform.position = pos;
        clone.transform.parent = transform;

        poolInstances.Add(clone);

        return clone;
    }
    // Once the object goes off screen, then this will look to create an instance of the next gameobject.
    public RecycleGameobject NextObject(Vector3 pos)
    {
        RecycleGameobject instance = null;

        foreach(var go in poolInstances)
        {
            if(go.gameObject.activeSelf != true)
            {
                    instance = go;
                    instance.transform.position = pos;
            }
        }
        if(instance == null)
             instance = CreateInstance(pos);

        instance.Restart();

        return instance;
    }
}
