using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class UnityEventHitData : UnityEvent<HitData> {}

public class GameEventHitDataListener : MonoBehaviour
{
    [SerializeField]
    GameEventHitData eventToListen;
    [SerializeField]
    UnityEventHitData actions;

    void Start()
    {
        if (eventToListen != null)
            eventToListen.AddListener(this);
    }

    public void Invoke(HitData hitData)
    {
        actions.Invoke(hitData);
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