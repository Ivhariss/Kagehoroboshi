using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot slot;
    public static ItemBox instance;
    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    public void SetItem(Item item)
    {
        slot.SetItem(item);
    }
}
