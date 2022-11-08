using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithStock : RifleDecorator
{
    private float stockAccuracy = 10.0f;

    public WithStock(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + stockAccuracy;
    }

    public override GameObject LoadPart()
    {
        GameObject part = (GameObject)Resources.Load("Stock");
        return part;
    }
}
