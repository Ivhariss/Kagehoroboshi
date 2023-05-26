using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
public class EnemyScript : MonoBehaviour
{
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
    private NavMeshAgent agent;
    private GameObject _player;
    private float _distance;//敵からプレイヤーまでの距離

    private void Awake()
    {
        enemyStatus = GameObject.Find("EnemyStats").GetComponent<EnemyStatus>();
    }
    private void Start()
    {
        _player = GameObject.Find("Player");
        agent = this.GetComponent<NavMeshAgent>();
        EnemyAction(this.enemyType, 10f);

    }
    private void Update()
    {
        
    }
    /// <summary>
    /// プレイヤーが索敵外の時の動き
    /// </summary>
    void EnemyIdle()
    {

    }

    /// <summary>
    /// 敵の索敵と追跡
    /// </summary>
    /// <param name="enemyType"></param>
    /// <param name="enemySearchRange"></param>
    void EnemyAction(EnemyType enemyType, float enemySearchRange)
    {       
        _distance = (_player.transform.position - transform.position).sqrMagnitude;
        //索敵
        if (_distance < enemySearchRange * enemySearchRange)
        {
            if (_distance >= 100f)
            {
                EnemyMove();        //enemyの追跡(索敵範囲内かつ攻撃範囲内の時)
                
            }
            else if(_distance < 100f)
            {
                switch (enemyType)      //enemyの攻撃()
                {
                    case EnemyType.Bird:
                        BirdAttack();
                        break;
                    case EnemyType.Fish:
                        FishAttack();
                        break;
                    case EnemyType.Beast:
                       StartCoroutine( BearAttackSelect());
                        Debug.Log(_distance);
                        break;
                }
            }
        }
        else
        {
            EnemyIdle();        //索敵範囲外の時
        }
    }
    /// <summary>
    /// 熊の攻撃
    /// </summary>
    IEnumerator BearAttackSelect()
    {
        int randomAction = Random.Range(0, 2);
        Debug.Log(randomAction);
        if (randomAction == 0)//攻撃A
        {

        }
        else if(randomAction == 1)//攻撃Ｂ
        {
            
            yield return StartCoroutine(CountTime());
            
        }
    }
    /// <summary>
    ///鳥の攻撃
    /// </summary>
    void BirdAttack()
    {

    }
    /// <summary>
    /// 魚の攻撃
    /// </summary>
    void FishAttack()
    {

    }

    private void EnemyMove()
    {
        agent.SetDestination(_player.transform.position);
    }

    //----------熊の攻撃処理----------
    IEnumerator BearAttackA ()
    {
        yield return null;
    }

    IEnumerator BearAttackB()
    {
        float distance = enemyStatus.enemyStatuses[1]._enemySpeed * Time.deltaTime;
        Vector3.MoveTowards(this.transform.position, _player.transform.position, enemyStatus.enemyStatuses[1]._enemySpeed * Time.deltaTime);
        yield return null;
    }
    //５秒間移動する
    IEnumerator CountTime()
    {
        float elapsedTime = 0f;
        float duration = 5f;
        while(elapsedTime < duration)
        {
            StartCoroutine(BearAttackB());
            elapsedTime += Time.deltaTime;  
        }
        yield return null;
    }

    //----------熊の攻撃処理----------
}
