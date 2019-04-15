using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct HitData
{
    public InstrumentType InstrumentType;
    public float Magnitude; //Corresponds to the magnitude of the collider's velocity that hit the instrument

    public HitData(InstrumentType InstrumentType, float Magnitude)
    {
        this.InstrumentType = InstrumentType;
        this.Magnitude = Magnitude;
    }
}
