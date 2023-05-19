using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [System.Serializable]
    private enum EnemyType
    {
        Bird,
        Beast,
        Fish,
        Ghost,
        Statue
    }
    [SerializeField]private EnemyType enemyType;
    [SerializeField]private EnemyStatus enemyStatus;
    [SerializeField] private float enemySeachRange;
    private GameObject _player;
    private float _distance;//�G����v���C���[�܂ł̋���

    private void Start()
    {
        _player = GameObject.Find("Player");

    }
    private void Update()
    {
    }
    /// <summary>
    /// �v���C���[�����G�O�̎��̓���
    /// </summary>
    void EnemyIdle()
    {

    }

    /// <summary>
    /// �G�̍��G�ƒǐ�
    /// </summary>
    /// <param name="enemyType"></param>
    /// <param name="enemySearchRange"></param>
    void EnemyAction(EnemyType enemyType, float enemySearchRange)
    {
        _distance = (_player.transform.position - transform.position).sqrMagnitude;
        //���G
        if (_distance < enemySearchRange * enemySearchRange)
        {
            
        }
    }
    /// <summary>
    /// �G�̍U��
    /// </summary>
    void EnemyAttack()
    {

    }
}
