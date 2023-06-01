using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

//  UI使うときはこれ入れるといいらしい、というあやふやな感じで入ってる
using UnityEngine.UI;

public class ItemUIScript : MonoBehaviour
{
    //  60FPSに設定する
    //  明らかにUIのスクリプトに組み込むものではないから、後で切り離した方がいいはず。
    //Application.targetFrameRate = 60; 


    //  アイテムの耐久度の最小公倍数が60だったので、一旦最大耐久度を60に。
    private float MaxDurability = 60;
    //  現耐久度の設定
    private float CurrentDurability;
    //  スライダーの導入
    public Slider slider;

    //  アイテム使用判定を偽に
    bool ItemUse = false;
    //  アイテムの種類（試験的に、今回は懐中電灯のつもりで）
    int ItemNumber = 2;

    // Start is called before the first frame update
    void Start()
    {
        //  sliderを満タンに
        slider.value = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //  ここにアイテム取得時の関数書くといいのかもしれない？
        if(Input.GetKeyDown(KeyCode.R))
        {
            //  取得したアイテムに応じてItemNumberを変える、とか？

            //  現耐久度を一旦最大耐久度と同じにする
            CurrentDurability = MaxDurability;
            UnityEngine.Debug.Log("耐久度満タンの処理完了！！");
        }

        //  Tキーを押したらアイテム切り替えたってことに一旦する
        if (Input.GetKeyDown(KeyCode.T))
        {
            //  アイテム使用中のbool切替
            ItemUse = !ItemUse;
        }

        //  アイテムを使っている間は仕様書通りの耐久度の減らし方をしたい
        //  懐中電灯は20秒で壊れるから、20*60=1200フレームで壊れる。
        if (ItemUse){
            switch (ItemNumber)
            {
                case 2:
                    CurrentDurability -= Time.deltaTime * 3;
                    break;
            }
        }

        //  スライダーを変更
        slider.value = CurrentDurability;
    }
}
