using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessCharaAnimEvent : MonoBehaviour
{
    private PlayerController playerController;
    [SerializeField]
    private Collider itemCollider;

    // Start is called before the first frame update
    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    void AttackStart()
    {
        itemCollider.enabled = true;
    }

    void AttackEnd()
    {
        itemCollider.enabled = false;
    }

    void StartEnd()
    {
        playerController.SetState(PlayerController.MyState.Normal);
    }

    public void EndDamage()
    {
        playerController.SetState(PlayerController.MyState.Normal);
    }

    public void SetCollider(Collider col)
    {
        itemCollider = col;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
