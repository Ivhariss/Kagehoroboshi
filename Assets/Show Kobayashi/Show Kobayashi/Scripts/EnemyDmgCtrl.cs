using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EnemyDmgCtrl : MonoBehaviour
{
    PlayerAction action;
    [SerializeField] private int enemyTypeNum;
    [SerializeField] private float maxHealth;
    private float currentHealth;
    private EnemyStatus enemyStatus;
    private Material enemyMaterial;
    private float alpha = 1.0f;
    [SerializeField] private float fadeOutTime;//fadeoutŽžŠÔ
    private float fadeOutSpeed;//fadeout‘¬“x
    public int destroyedStatueCounter = 0;
    private void Awake()
    {
        enemyStatus = GameObject.Find("EnemyStats").GetComponent<EnemyStatus>();
    }
    void Start()
    {
<<<<<<< HEAD
        Debug.Log(enemyStatus.enemyStatuses[enemyTypeNum]._enemyHP);
=======
>>>>>>> origin/tanaka
        maxHealth = enemyStatus.enemyStatuses[enemyTypeNum]._enemyHP;
        currentHealth = maxHealth;
        Renderer renderer = GetComponent<Renderer>();
        enemyMaterial = renderer.material;
        fadeOutSpeed = 1.0f / fadeOutTime;
        Color color = enemyMaterial.color;
        color.a = alpha;
        enemyMaterial.color = color;
        action = new PlayerAction();
        action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.kKey.isPressed)
        {
            TakeDmg(1f);
        }
    }

   public void TakeDmg(float dmgAmount)
    {
        currentHealth -= dmgAmount;
        if(currentHealth <= 0)
        {
            StartCoroutine(Die());
        }
    }

    private IEnumerator Die()
    {
        while (alpha > 0f)
        {
            alpha -= fadeOutSpeed * Time.deltaTime; ;
            Color color = enemyMaterial.color;
            color.a = alpha;
            enemyMaterial.color= color;

            yield return new WaitForSeconds(0.03f);
        }
        SealedWall.DestroyedStatue++;
        gameObject.SetActive(false);
    }
}
