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
    private float _distance;//“G‚©‚çƒvƒŒƒCƒ„[‚Ü‚Å‚Ì‹——£

    private void Start()
    {
        _player = GameObject.Find("Player");

    }
    private void Update()
    {
    }
    /// <summary>
    /// ƒvƒŒƒCƒ„[‚ªõ“GŠO‚Ì‚Ì“®‚«
    /// </summary>
    void EnemyIdle()
    {

    }

    /// <summary>
    /// “G‚Ìõ“G‚Æ’ÇÕ
    /// </summary>
    /// <param name="enemyType"></param>
    /// <param name="enemySearchRange"></param>
    void EnemyAction(EnemyType enemyType, float enemySearchRange)
    {
        _distance = (_player.transform.position - transform.position).sqrMagnitude;
        //õ“G
        if (_distance < enemySearchRange * enemySearchRange)
        {
            
        }
    }
    /// <summary>
    /// “G‚ÌUŒ‚
    /// </summary>
    void EnemyAttack()
    {

    }
}
