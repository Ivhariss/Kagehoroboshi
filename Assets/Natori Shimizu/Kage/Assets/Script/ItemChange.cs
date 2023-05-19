using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemChange : MonoBehaviour
{
    [SerializeField]
    private GameObject[] item;
    private int equipment;
    private ProcessCharaAnimEvent processCharaAnimEvent;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
        processCharaAnimEvent = transform.root.GetComponent<ProcessCharaAnimEvent>();

        equipment = 0;
        item[equipment].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("L1") || Input.GetKeyDown("Tryangel"))
        {
            ChangeItem();
        }
    }

    void ChangeItem()
    {
        equipment++;
        if (equipment >= item.Length)
        {
            equipment = 0;
        }

        for (var i = 0; i < item.Length; i++)
        {
            if (i == equipment)
            {
                item[i].SetActive(true);
                processCharaAnimEvent.SetCollider(item[i].GetComponent<Collider>());
            }
            else
            {
                item[i].SetActive(false);
            }
        }
    }
}
