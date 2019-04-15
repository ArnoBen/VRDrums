
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    GameEvent eventToListen;
    [SerializeField]
    UnityEvent actions;

    void Start()
    {
        if (eventToListen != null)
            eventToListen.AddListener(this);
    }

    public void Invoke()
    {
        actions.Invoke();
    }

    void OnDisable()
    {
        Unsubscribe();
    }

    void Unsubscribe()
    {
        eventToListen.RemoveListener(this);
    }
}