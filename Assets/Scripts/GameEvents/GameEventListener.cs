
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
 
public class GameEventListener : MonoBehaviour
{
    [SerializeField]
    GameEvent eventToListen;
    [SerializeField]
    UnityEvent Actions;
 
    void Start()
    {
        eventToListen.AddListener(this);
    }
 
    public void DoThings()
    {
        Actions.Invoke();
    }

    void OnDestroy()
    {
        eventToListen.RemoveListener(this);
    }
}