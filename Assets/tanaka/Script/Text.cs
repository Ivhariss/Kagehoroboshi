using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    //gameobject��z�u���Ă��̃X�N���v�g���A�^�b�`����

    [SerializeField]
    [Tooltip("�t�F�[�h�����鎞��(�b)")]
    private float fadeTime = 1f;
    private float timer;
    private float alpha;

    void Start()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = alpha;
        alpha = 0;
    }

    void Update()
    {
        
    }

    void FadeIn()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = timer / fadeTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        timer += Time.deltaTime;
        Debug.Log("sdda");
        if (alpha == 0)
        {
            FadeIn();
        }

    }

}


    //Trigger�Ƀ`�F�b�N���Ă��炤��
    /*
    private void OnTriggerEnter(Collider other)
    {
 
    }
    
    private IEnumerator TextMap() //�R���[�`���֐��̖��O
    {
        yield return new WaitForSeconds(8.0f);

        this.gameObject.GetComponent<CanvasGroup>().alpha = timer * fadeTime;
        Debug.Log("�X�^�[�g����3�b��");
    }*/

