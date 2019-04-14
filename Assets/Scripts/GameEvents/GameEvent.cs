﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
[CreateAssetMenu(menuName = "GameEvent")]
public class GameEvent : ScriptableObject
{
    List<GameEventListener> listeners;
 
    void OnEnable()
    {
        listeners = new List<GameEventListener>();
    }

    public void AddListener(GameEventListener gameEventListener)
    {
        listeners.Add(gameEventListener);
    }

    public void RemoveListener(GameEventListener gameEventListener)
    {
        listeners.Remove(gameEventListener);
    }
 
    public void Raise()
    {
        foreach (GameEventListener listener in listeners)
            listener.DoThings();
    }
}