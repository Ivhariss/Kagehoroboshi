using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  UI�g���Ƃ��͂�������Ƃ����炵���A�Ƃ�������ӂ�Ȋ����œ����Ă�
using UnityEngine.UI;

public class ItemUIScript : MonoBehaviour
{
    //  �A�C�e���̑ϋv�x�̍ŏ����{����60�������̂ŁA��U�ő�ϋv�x��60�ɁB
    private int MaxDurability = 60;
    //  ���ϋv�x�̐ݒ�
    private int CurrentDurability;
    //  �X���C�_�[�̓���
    public Slider slider;

    //  �A�C�e���g�p������U��
    bool ItemUse = false;

    // Start is called before the first frame update
    //  �������A�C�e���擾���̏����Ƃ��ď���������΂悳�����H
    void Start()
    {
        //  slider�𖞃^����
        slider.value = 60;

        //  ���ϋv�x����U�ő�ϋv�x�Ɠ����ɂ���
        CurrentDurability = MaxDurability;
        Debug.Log("�ϋv�x���^���̏��������I�I");
    }

    // Update is called once per frame
    void Update()
    {
        //  T�L�[����������A�C�e���؂�ւ������Ă��ƂɈ�U����
        if (Input.GetKey(KeyCode.T)){
            ItemUse = true;
        }

        //  �A�C�e�����g���Ă���Ԃ͎d�l���ʂ�̑ϋv�x�̌��炵����������
        if (ItemUse){

        }
    }
}
