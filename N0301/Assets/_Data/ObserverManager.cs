using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager<T>
{
    static Dictionary<string, List<Action<T>>> listensers = new();

    public static void AddObserver(string observerEnum, Action<T> callback)
    {
        if(listensers.ContainsKey(observerEnum)) return;
        listensers.Add(observerEnum, new List<Action<T>>());

        listensers[observerEnum].Add(callback);
    }

    public static void RemoveObserver(string observerEnum, Action<T> callback)
    {
        if (!listensers.ContainsKey(observerEnum)) return;
        listensers[observerEnum].Remove(callback);
    }

    public static void Notify(string observerEnum, T param)
    {
        if(!listensers.ContainsKey(observerEnum)) return;

        foreach (var child in listensers[observerEnum])
        {
            child?.Invoke(param);
        }
    }
}
