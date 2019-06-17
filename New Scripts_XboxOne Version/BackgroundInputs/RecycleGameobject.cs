using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRecycle
{
    void Restart();
    void Shutdown();
}

public class RecycleGameobject : MonoBehaviour {

    private List<IRecycle> recycleComponents;

     void Awake()
    {
        var components = GetComponents<MonoBehaviour>();
        recycleComponents = new List<IRecycle>();
        foreach (var component in components)
        {
            if(component is IRecycle)
            {
                recycleComponents.Add(component as IRecycle);
            }
        }
        
    }

    //Calls method when the gameobject is restarted after going offscreen.
    public void Restart()
    {
        gameObject.SetActive(true);

        foreach(var component in recycleComponents)
        {
            component.Restart();
        }
    }
    // Calls method on the gameobject after going offscreen.
    public void Shutdown()
    {
        gameObject.SetActive(false);

        foreach (var component in recycleComponents)
        {
            component.Shutdown();
        }
    }
}
