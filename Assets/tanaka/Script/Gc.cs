using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gc : MonoBehaviour
{
    public float fadetime = 1.0f; // �t�F�[�h�̎���

    private Image image;
    private bool fadingIn = true;

    void Start()
    {
        image = GetComponent<Image>(); // �t�F�[�h���s�������I�u�W�F�N�g��Image�R���|�[�l���g���擾
        StartFade();

    }

    void Update()
    {
        if (fadingIn)
        {
            // �t�F�[�h�C�����͓����x�𑝂₷
            image.color = new Color(image.color.r, image.color.g, image.color.b, Mathf.Lerp(image.color.a, 1f, Time.deltaTime / fadetime));
        }
        else
        {
            // �t�F�[�h�A�E�g���͓����x�����炷
            image.color = new Color(image.color.r, image.color.g, image.color.b, Mathf.Lerp(image.color.a, 0f, Time.deltaTime / fadetime));
        }
    }

    void StartFade()
    {
        fadingIn = true; // �t�F�[�h�C�����J�n
        Invoke("StartFadeOut", fadetime); // �w�肵�����Ԍ�Ƀt�F�[�h�A�E�g���J�n����
    }

    void StartFadeOut()
    {
        fadingIn = false; // �t�F�[�h�A�E�g���J�n
    }
}

