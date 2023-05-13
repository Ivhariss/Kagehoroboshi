using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleStatus : MonoBehaviour
{
   public GameObject[] targets;

    private List<float> disList = new List<float>();

    // ��ԋ߂��G�̎擾
    private GameObject nearestEnemy;

    // Update is called once per frame
    void Update()
    {
        HotaruMove();
    }

    void HotaruMove()
    {
        // ��ʏ�ň�ԋ߂��G��T���d�g��
        foreach (GameObject t in targets)
        {
            float distance = Vector3.Distance(transform.position, t.transform.position);

            disList.Add(distance);

        }

        // ��ԋ߂��G�̕����Ɍ����B
        transform.root.LookAt(nearestEnemy.transform);
    }
}
