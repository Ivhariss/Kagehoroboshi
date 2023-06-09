using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slot : MonoBehaviour
{
    Image image;
    /*
     * �X�v���C�g�z��̔ԍ�
     ���C�^�[ : 0
     �����d�� : 1
     
     
     
     
     */
    [SerializeField] private Sprite[] itemImage;
    static public int itemImageIndex = 0;
    private void Awake()
    {
       image = GetComponent<Image>();
    }

    public void SetItem(int itemImageIdx)
    {
        
        //UI�\���̃A�C�e���̐؂�ւ��X�v���C�g�z��Q��
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
