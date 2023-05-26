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
    private float _distance;//�G����v���C���[�܂ł̋���

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
            if (_distance >= 100f)
            {
                EnemyMove();        //enemy�̒ǐ�(���G�͈͓����U���͈͓��̎�)
                
            }
            else if(_distance < 100f)
            {
                switch (enemyType)      //enemy�̍U��()
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
            EnemyIdle();        //���G�͈͊O�̎�
        }
    }
    /// <summary>
    /// �F�̍U��
    /// </summary>
    IEnumerator BearAttackSelect()
    {
        int randomAction = Random.Range(0, 2);
        Debug.Log(randomAction);
        if (randomAction == 0)//�U��A
        {

        }
        else if(randomAction == 1)//�U���a
        {
            
            yield return StartCoroutine(CountTime());
            
        }
    }
    /// <summary>
    ///���̍U��
    /// </summary>
    void BirdAttack()
    {

    }
    /// <summary>
    /// ���̍U��
    /// </summary>
    void FishAttack()
    {

    }

    private void EnemyMove()
    {
        agent.SetDestination(_player.transform.position);
    }

    //----------�F�̍U������----------
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
    //�T�b�Ԉړ�����
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

    //----------�F�̍U������----------
}
