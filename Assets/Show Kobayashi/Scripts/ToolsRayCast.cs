using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToolsRayCast : MonoBehaviour
{
    private EnemyDmgCtrl dmgCtrl;
    [Header("光力(敵に与えるダメージ)")]
    [SerializeField] private float dmgAmount; //光力（敵に与えるダメージ）
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            dmgCtrl = other.gameObject.GetComponent<EnemyDmgCtrl>();
            Debug.Log(other.GetComponent<EnemyDmgCtrl>());
            dmgCtrl.TakeDmg(dmgAmount);
        }
    }
}
