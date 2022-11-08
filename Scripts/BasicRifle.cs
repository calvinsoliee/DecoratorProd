using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicRifle : IRifle
{
    private float basicAccuracy = 5.0f;

    public float GetAccuracy()
    {
        return basicAccuracy;
    }

    public GameObject LoadPart()
    {
        GameObject part = (GameObject)Resources.Load("Basic");
        return part;
    }
}
