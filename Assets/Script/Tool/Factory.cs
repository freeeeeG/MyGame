using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public static class Factory
{
    public static Dictionary<string, List<GameObject>> objectPool = new Dictionary<string, List<GameObject>>();
    public static GameObject Create<T>(T prefab) where T : MonoBehaviour
    {
        Type type = typeof(T);
        string name = type.Name;
        if (objectPool.ContainsKey(name))
        {
            foreach (var item in objectPool[name])
            {
                if (!item.activeSelf)
                {
                    item.SetActive(true);
                    return item;
                }
            }
        }
        else
        {
            objectPool.Add(name, new List<GameObject>());
        }
        var obj = GameObject.Instantiate(prefab);
        obj.name = name;
        objectPool[name].Add(obj.gameObject);
        return obj.gameObject;
    }

}
