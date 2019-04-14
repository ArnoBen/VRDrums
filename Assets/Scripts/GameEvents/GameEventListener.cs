
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
 
public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    GameEvent eventToListen;
    [SerializeField]
    UnityEvent thingsToDoWhenEventIsRaised;
 
    void Start()
    {
        eventToListen.AddListener(this);
    }
 
    public void DoThings()
    {
        thingsToDoWhenEventIsRaised.Invoke();
    }

    void OnDestroy()
    {
        eventToListen.RemoveListener(this);
    }
}