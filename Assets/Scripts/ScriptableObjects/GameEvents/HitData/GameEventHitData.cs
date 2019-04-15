using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameEventHitData")]
public class GameEventHitData : ScriptableObject
{
    List<GameEventHitDataListener> listeners = new List<GameEventHitDataListener>();

    public void AddListener(GameEventHitDataListener gameEventHitDataListener)
    {
        if (!listeners.Contains(gameEventHitDataListener))
            listeners.Add(gameEventHitDataListener);
    }

    public void RemoveListener(GameEventHitDataListener gameEventHitDataListener)
    {
        if (listeners.Contains(gameEventHitDataListener))
            listeners.Remove(gameEventHitDataListener);
    }

    public void Raise(HitData hitData)
    {
        foreach (GameEventHitDataListener listener in listeners)
            listener.Invoke(hitData);
    }
}