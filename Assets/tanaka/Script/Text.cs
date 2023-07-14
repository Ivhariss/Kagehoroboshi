using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    //gameobjectを配置してこのスクリプトをアタッチする

    [SerializeField]
    [Tooltip("フェードさせる時間(秒)")]
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


    //Triggerにチェックしてもらうと
    /*
    private void OnTriggerEnter(Collider other)
    {
 
    }
    
    private IEnumerator TextMap() //コルーチン関数の名前
    {
        yield return new WaitForSeconds(8.0f);

        this.gameObject.GetComponent<CanvasGroup>().alpha = timer * fadeTime;
        Debug.Log("スタートから3秒後");
    }*/

