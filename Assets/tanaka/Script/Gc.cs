using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gc : MonoBehaviour
{
    public float fadetime = 1.0f; // フェードの時間

    private Image image;
    private bool fadingIn = true;

    void Start()
    {
        image = GetComponent<Image>(); // フェードを行いたいオブジェクトのImageコンポーネントを取得
        StartFade();

    }

    void Update()
    {
        if (fadingIn)
        {
            // フェードイン中は透明度を増やす
            image.color = new Color(image.color.r, image.color.g, image.color.b, Mathf.Lerp(image.color.a, 1f, Time.deltaTime / fadetime));
        }
        else
        {
            // フェードアウト中は透明度を減らす
            image.color = new Color(image.color.r, image.color.g, image.color.b, Mathf.Lerp(image.color.a, 0f, Time.deltaTime / fadetime));
        }
    }

    void StartFade()
    {
        fadingIn = true; // フェードインを開始
        Invoke("StartFadeOut", fadetime); // 指定した時間後にフェードアウトを開始する
    }

    void StartFadeOut()
    {
        fadingIn = false; // フェードアウトを開始
    }
}

