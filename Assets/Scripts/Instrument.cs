using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrument : MonoBehaviour
{
    [SerializeField] GameEventHitData gameEvent;
    [SerializeField] InstrumentType type;
    public delegate void OnCollisionDelegate();
    public event OnCollisionDelegate onInteraction;

    void OnTriggerEnter(Collider other)
    {
        float magnitude = 1f;
        if (other.attachedRigidbody != null)
            magnitude = other.attachedRigidbody.angularVelocity.magnitude; //Max rotation speed is 7 (at least on my computer !).
        gameEvent.Raise(new HitData(type, magnitude));
        if (onInteraction != null) onInteraction();
    }

    void OnCollisionEnter(Collision other)
    {
        float magnitude = 1f;
        if( other.rigidbody != null)
            magnitude = other.rigidbody.angularVelocity.magnitude; //See OnTriggerEnter.
        gameEvent.Raise(new HitData(type, magnitude));
        if (onInteraction != null) onInteraction();
    }
}
