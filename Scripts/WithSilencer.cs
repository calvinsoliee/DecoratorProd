using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithSilencer : RifleDecorator
{
    private float silencerAccuracy = 5.0f;

    public WithSilencer(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + silencerAccuracy;
    }

    public override GameObject LoadPart()
    {
        GameObject part = (GameObject)Resources.Load("Silencer");
        return part;
    }
}
