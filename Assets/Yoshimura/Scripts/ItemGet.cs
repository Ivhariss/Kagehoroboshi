using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    //問題点
    //アイテムの獲得はできるが、複数所持ができてしまっている
    //生成位置が変
    //アイテムがなくなった時、ライターが自動で獲得する処理ができていません。

    [SerializeField]
    private GameObject[] item;//０がライター、１が懐中電灯、２がカメラ
    GameObject player;
    GameObject Obj;

    void Start()
    {
        player = GameObject.Find("Itembox");//""の中はアイテムを持たせるオブジェクトの名前
    }

    private void OnTriggerStay(Collider other)
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.tag == "lighter")
            {
              //  Debug.Log("aaaa");
                Obj = (GameObject)Instantiate(item[0], this.transform.position, Quaternion.identity);
                Obj.transform.parent = player.transform;
            }
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.tag == "HandLight")
            {
              //  Debug.Log("aaaa");
                Obj = (GameObject)Instantiate(item[1], this.transform.position, Quaternion.identity);
                Obj.transform.parent = player.transform;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.tag == "Camera")
            {
              //  Debug.Log("aaaa");
                Obj = (GameObject)Instantiate(item[2], this.transform.position, Quaternion.identity);
                Obj.transform.parent = player.transform;
            }
        }
    }
}
