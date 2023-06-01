using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Item 
{
    public enum Type
    {
        Lighter,
        HandLight,
        Lanthanum,
        Hotaru,
        Camera,
    }

    public Type type;
    public Sprite sprite;
}
