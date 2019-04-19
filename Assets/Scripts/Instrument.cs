using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instrument : MonoBehaviour
{
    [SerializeField] GameEventHitData gameEvent;
    [SerializeField] InstrumentType type;
    public delegate void OnCollisionDelegate();
    public event OnCollisionDelegate onInteraction;


    void OnCollisionEnter(Collision other)
    {
        float magnitude = GetMagnitude(other);
        gameEvent.Raise(new HitData(type, magnitude));
        if (onInteraction != null) onInteraction();
    }

    float GetMagnitude(Collision other)
    {
        //Condition to add when using VR to correctly get a velocity. There will be an issue when using the controllers.
        //Debug.Log(other.impulse.magnitude);
        float magnitude = 1f;
        if (other.rigidbody != null)
            magnitude = other.rigidbody.angularVelocity.magnitude;
        return magnitude;
    }
}
