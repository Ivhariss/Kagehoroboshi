using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleStatus : MonoBehaviour
{
   public GameObject[] targets;

    private List<float> disList = new List<float>();

    // 一番近い敵の取得
    private GameObject nearestEnemy;

    // Update is called once per frame
    void Update()
    {
        HotaruMove();
    }

    void HotaruMove()
    {
        // 画面上で一番近い敵を探す仕組み
        foreach (GameObject t in targets)
        {
            float distance = Vector3.Distance(transform.position, t.transform.position);

            disList.Add(distance);

        }

        // 一番近い敵の方向に向く。
        transform.root.LookAt(nearestEnemy.transform);
    }
}
