using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [System.Serializable]
    private enum EnemyType
    {
        Bird,
        Beast,
        Fish,
        Ghost
    }

    [SerializeField] private EnemyType pattern;
    private EnemyStatus enemyStatus;
    // Start is called before the first frame update
    void Start()
    {
        enemyStatus = GameObject.Find("EnemyStats").GetComponent<EnemyStatus>();
        Debug.Log(enemyStatus.enemyStatuses[0]._enemyName);
    }

    // Update is called once per frame
    void Update()
    {
        switch (pattern)
        {
            case EnemyType.Bird:
                break;
            case EnemyType.Beast:
                break;
            case EnemyType.Fish:
                break;
            case EnemyType.Ghost:
                break;
        }
    }
    //
    private void BirdEnemy()
    {
        
    }

}
