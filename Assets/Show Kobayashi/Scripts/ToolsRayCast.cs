using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ToolsRayCast : MonoBehaviour
{
    private EnemyDmgCtrl dmgCtrl;
    [Header("����(�G�ɗ^����_���[�W)")]
    [SerializeField] private float dmgAmount; //���́i�G�ɗ^����_���[�W�j
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
