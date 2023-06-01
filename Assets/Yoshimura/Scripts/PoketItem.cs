using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PoketItem
{
    public Type type; // Ží—Þ
    public Sprite sprite; // ‰æ‘œ(’Ç‰Á)
    public GameObject Item;

    public enum Type
    {
        LightItem,
    }

    public PoketItem(PoketItem item)
    {
        this.type = item.type;
        this.sprite = item.sprite; // ‰æ‘œ(’Ç‰Á)
        this.Item = item.Item;
    }
}
