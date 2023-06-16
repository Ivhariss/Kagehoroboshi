using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour 
{
    [SerializeField]private GameObject[] items;
    [SerializeField] private Transform toolPos;

    /// <summary>
    /// ƒAƒCƒeƒ€‚ğ‚Âˆ—
    /// </summary>
    /// <param name="itemNum"></param>
    public void InstantiateItem(int itemNum)
    {
        switch(itemNum)
        {
            case 0:
                Instantiate(items[itemNum], toolPos);
                break;
            case 1:
                Instantiate(items[itemNum], toolPos);
                break;
        }
    }
}
