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
    [SerializeField] private float walkingTime = 0f;
    [SerializeField] private EnemyType pattern;
    private int enemyAct;
    private Vector3 playerPos;
    private Vector3 currentPos;
    private EnemyStatus enemyStatus;
    private bool isWaiting = false;
    [SerializeField] private GameObject playerObj;
    /* MEMO
     
     
     */
    void Start()
    {
        playerObj = GameObject.Find("Player");
        enemyStatus = GameObject.Find("EnemyStats").GetComponent<EnemyStatus>();       
    }
    private void Update()
    {
        
    }
    //--------各敵キャラのアニメーション
    private void BirdEnemyAnim()
    {
        if (pattern == EnemyType.Bird)
        {

        }
        else if (pattern == EnemyType.Beast)
        {
            //StartCoroutine(BeastEnemyAction());
        }
        else if (pattern == EnemyType.Fish)
        {

        }
        else if (pattern == EnemyType.Ghost)
        {

        }
        else if (pattern == EnemyType.Statue)
        {

        }
    }
    private IEnumerator BeastEnemyAction()
    {
        if(Random.value < 0.5f)
        {
            yield return StartCoroutine(BeastWalk(0f));
        }
        else
        {
            yield return StartCoroutine (BeastWalk(0f));
        }

        isWaiting = false;
        /*if(!isWaiting)
        {
            enemyAct = 0; //Random.Range(0, 2);
            if (enemyAct == 0)//歩き
            {
                StartCoroutine(BeastWalk(0f));
            }
            else if (enemyAct == 1)//突進
            {
                StartCoroutine(BeastRush(0f));
            }
        }*/
        

    }
    //獣キャラの歩く処理
    private IEnumerator BeastWalk(float timer)
    {
        walkingTime = 5f;
        isWaiting = false;
        playerPos = playerObj.transform.position;
        while (!isWaiting)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPos, enemyStatus.enemyStatuses[1]._enemySpeed / 60 / 60 * Time.deltaTime);
            timer += Time.deltaTime;
            if(timer >= walkingTime)
            {
                isWaiting = true;
            }
        }
        //isWaiting = false;
        
        yield return StartCoroutine(BeastEnemyAction());
    }
    //獣キャラの突進
    private IEnumerator BeastRush(float timer)
    {
        walkingTime = 3f;
        isWaiting = false;
        Vector3 playerCurrentPos = playerObj.transform.position;
        yield return new WaitForSeconds(1.0f);
        timer = 0f;
        while (!isWaiting)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPos, enemyStatus.enemyStatuses[1]._enemySpeed / 60 / 60 * 6.5f * Time.deltaTime);
            timer += Time.deltaTime;
            if(timer >= walkingTime)
            {
                isWaiting = true;
            }
        }
        //isWaiting = false;

        yield return StartCoroutine(BeastEnemyAction());
    }
    private void FishEnemyAnim()
    {

    }

    private void GhostEnemyAnim()
    {

    }
    
}
