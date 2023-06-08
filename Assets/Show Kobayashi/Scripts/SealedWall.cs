using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealedWall : MonoBehaviour
{
    static public int DestroyedStatue = 0;
    [SerializeField] int setUnSealedIdx;
    private Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DestroyWall();
    }

    private void DestroyWall()
    {
        if (DestroyedStatue == setUnSealedIdx)
        {

            Animator.SetBool("isDestroyed", true);
        }
        
    }
    private void Destroyed()
    {
        gameObject.SetActive(false);
    }
}
