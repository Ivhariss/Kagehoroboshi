using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PoketItem
{
    public Type type; // ���
    public Sprite sprite; // �摜(�ǉ�)
    public GameObject Item;

    public enum Type
    {
        LightItem,
    }

    public PoketItem(PoketItem item)
    {
        this.type = item.type;
        this.sprite = item.sprite; // �摜(�ǉ�)
        this.Item = item.Item;
    }
}
