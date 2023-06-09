using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slot : MonoBehaviour
{
    Image image;
    /*
     * スプライト配列の番号
     ライター : 0
     懐中電灯 : 1
     
     
     
     
     */
    [SerializeField] private Sprite[] itemImage;
    static public int itemImageIndex = 0;
    private void Awake()
    {
       image = GetComponent<Image>();
    }

    public void SetItem(int itemImageIdx)
    {
        
        //UI表示のアイテムの切り替えスプライト配列参照
        switch(itemImageIdx)
        {
            case 1:
                UpdateImage(itemImage[itemImageIdx]);
                break;
            case 2:
                UpdateImage(itemImage[itemImageIdx]);
                break;
            default:
                UpdateImage(itemImage[0]);
                break;

        }
        
    }

    void UpdateImage(Sprite item)
    {
        image.sprite = item;
    }
}
