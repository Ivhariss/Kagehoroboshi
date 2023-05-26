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
    private float _distance;//“G‚©‚çƒvƒŒƒCƒ„[‚Ü‚Å‚Ì‹——£

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
            if (_distance >= 100f)
            {
                EnemyMove();        //enemy‚Ì’ÇÕ(õ“G”ÍˆÍ“à‚©‚ÂUŒ‚”ÍˆÍ“à‚Ì)
                
            }
            else if(_distance < 100f)
            {
                switch (enemyType)      //enemy‚ÌUŒ‚()
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
            EnemyIdle();        //õ“G”ÍˆÍŠO‚Ì
        }
    }
    /// <summary>
    /// ŒF‚ÌUŒ‚
    /// </summary>
    IEnumerator BearAttackSelect()
    {
        int randomAction = Random.Range(0, 2);
        Debug.Log(randomAction);
        if (randomAction == 0)//UŒ‚A
        {

        }
        else if(randomAction == 1)//UŒ‚‚a
        {
            
            yield return StartCoroutine(CountTime());
            
        }
    }
    /// <summary>
    ///’¹‚ÌUŒ‚
    /// </summary>
    void BirdAttack()
    {

    }
    /// <summary>
    /// ‹›‚ÌUŒ‚
    /// </summary>
    void FishAttack()
    {

    }

    private void EnemyMove()
    {
        agent.SetDestination(_player.transform.position);
    }

    //----------ŒF‚ÌUŒ‚ˆ—----------
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
    //‚T•bŠÔˆÚ“®‚·‚é
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

    //----------ŒF‚ÌUŒ‚ˆ—----------
}
