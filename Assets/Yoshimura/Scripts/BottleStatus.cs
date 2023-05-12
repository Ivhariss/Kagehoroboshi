using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleStatus : MonoBehaviour
{
   public GameObject[] targets;

    private List<float> disList = new List<float>();

    // ˆê”Ô‹ß‚¢“G‚Ìæ“¾
    private GameObject nearestEnemy;

    // Update is called once per frame
    void Update()
    {
        HotaruMove();
    }

    void HotaruMove()
    {
        // ‰æ–Êã‚Åˆê”Ô‹ß‚¢“G‚ğ’T‚·d‘g‚İ
        foreach (GameObject t in targets)
        {
            float distance = Vector3.Distance(transform.position, t.transform.position);

            disList.Add(distance);

        }

        // ˆê”Ô‹ß‚¢“G‚Ì•ûŒü‚ÉŒü‚­B
        transform.root.LookAt(nearestEnemy.transform);
    }
}
