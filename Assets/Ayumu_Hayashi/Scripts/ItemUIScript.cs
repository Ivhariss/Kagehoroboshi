using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

//  UI�g���Ƃ��͂�������Ƃ����炵���A�Ƃ�������ӂ�Ȋ����œ����Ă�
using UnityEngine.UI;

public class ItemUIScript : MonoBehaviour
{
    //  60FPS�ɐݒ肷��
    //  ���炩��UI�̃X�N���v�g�ɑg�ݍ��ނ��̂ł͂Ȃ�����A��Ő؂藣�������������͂��B
    //Application.targetFrameRate = 60; 


    //  �A�C�e���̑ϋv�x�̍ŏ����{����60�������̂ŁA��U�ő�ϋv�x��60�ɁB
    private float MaxDurability = 60;
    //  ���ϋv�x�̐ݒ�
    private float CurrentDurability;
    //  �X���C�_�[�̓���
    public Slider slider;

    //  �A�C�e���g�p������U��
    bool ItemUse = false;
    //  �A�C�e���̎�ށi�����I�ɁA����͉����d���̂���Łj
    int ItemNumber = 2;

    // Start is called before the first frame update
    void Start()
    {
        //  slider�𖞃^����
        slider.value = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //  �����ɃA�C�e���擾���̊֐������Ƃ����̂�������Ȃ��H
        if(Input.GetKeyDown(KeyCode.R))
        {
            //  �擾�����A�C�e���ɉ�����ItemNumber��ς���A�Ƃ��H

            //  ���ϋv�x����U�ő�ϋv�x�Ɠ����ɂ���
            CurrentDurability = MaxDurability;
            UnityEngine.Debug.Log("�ϋv�x���^���̏��������I�I");
        }

        //  T�L�[����������A�C�e���؂�ւ������Ă��ƂɈ�U����
        if (Input.GetKeyDown(KeyCode.T))
        {
            //  �A�C�e���g�p����bool�ؑ�
            ItemUse = !ItemUse;
        }

        //  �A�C�e�����g���Ă���Ԃ͎d�l���ʂ�̑ϋv�x�̌��炵����������
        //  �����d����20�b�ŉ��邩��A20*60=1200�t���[���ŉ���B
        if (ItemUse){
            switch (ItemNumber)
            {
                case 2:
                    CurrentDurability -= Time.deltaTime * 3;
                    break;
            }
        }

        //  �X���C�_�[��ύX
        slider.value = CurrentDurability;
    }
}
