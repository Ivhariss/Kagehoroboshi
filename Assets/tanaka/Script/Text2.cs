using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text2 : MonoBehaviour
{
    [SerializeField]
    [Tooltip("フェードさせる時間(秒)")]
    private float fadeTime = 1f;
    private float timer;
    private float alpha;
    void Start()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = alpha;
        alpha = 1;
    }

    void Update()
    {
        if (alpha == 0)
        {
            FadeOut();
        }
        
    }

    void FadeOut()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = Time.deltaTime / fadeTime;
    }
}
