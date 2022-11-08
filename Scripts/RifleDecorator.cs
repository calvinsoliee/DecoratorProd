using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleDecorator : IRifle
{
    protected IRifle decoratedRifle;

    public RifleDecorator(IRifle rifle)
    {
        decoratedRifle = rifle;
    }

    public virtual float GetAccuracy()
    {
        return decoratedRifle.GetAccuracy();
    }

    public virtual GameObject LoadPart()
    {
        return null;
    }
}
