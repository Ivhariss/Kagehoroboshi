using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PoketItem
{
    public Type type; // 種類
    public Sprite sprite; // 画像(追加)
    public GameObject Item;

    public enum Type
    {
        LightItem,
    }

    public PoketItem(PoketItem item)
    {
        this.type = item.type;
        this.sprite = item.sprite; // 画像(追加)
        this.Item = item.Item;
    }
}
