using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithMag : RifleDecorator
{
    public float magAccuracy = 1.0f;

    public WithMag(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + magAccuracy;
    }

    public override GameObject LoadPart()
    {
        GameObject part = (GameObject)Resources.Load("DrumMag");
        return part;
    }
}
