using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  UI使うときはこれ入れるといいらしい、というあやふやな感じで入ってる
using UnityEngine.UI;

public class ItemUIScript : MonoBehaviour
{
    //  アイテムの耐久度の最小公倍数が60だったので、一旦最大耐久度を60に。
    private int MaxDurability = 60;
    //  現耐久度の設定
    private int CurrentDurability;
    //  スライダーの導入
    public Slider slider;

    //  アイテム使用判定を偽に
    bool ItemUse = false;

    // Start is called before the first frame update
    //  ここをアイテム取得時の処理として書き換えればよさそう？
    void Start()
    {
        //  sliderを満タンに
        slider.value = 60;

        //  現耐久度を一旦最大耐久度と同じにする
        CurrentDurability = MaxDurability;
        Debug.Log("耐久度満タンの処理完了！！");
    }

    // Update is called once per frame
    void Update()
    {
        //  Tキーを押したらアイテム切り替えたってことに一旦する
        if (Input.GetKey(KeyCode.T)){
            ItemUse = true;
        }

        //  アイテムを使っている間は仕様書通りの耐久度の減らし方をしたい
        if (ItemUse){

        }
    }
}
