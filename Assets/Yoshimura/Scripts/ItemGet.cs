using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGet : MonoBehaviour
{
    //���_
    //�A�C�e���̊l���͂ł��邪�A�����������ł��Ă��܂��Ă���
    //�����ʒu����
    //�A�C�e�����Ȃ��Ȃ������A���C�^�[�������Ŋl�����鏈�����ł��Ă��܂���B

    [SerializeField]
    private GameObject[] item;//�O�����C�^�[�A�P�������d���A�Q���J����
    GameObject player;
    GameObject Obj;

    void Start()
    {
        player = GameObject.Find("Itembox");//""�̒��̓A�C�e������������I�u�W�F�N�g�̖��O
    }

    private void OnTriggerStay(Collider other)
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.tag == "lighter")
            {
              //  Debug.Log("aaaa");
                Obj = (GameObject)Instantiate(item[0], this.transform.position, Quaternion.identity);
                Obj.transform.parent = player.transform;
            }
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.tag == "HandLight")
            {
              //  Debug.Log("aaaa");
                Obj = (GameObject)Instantiate(item[1], this.transform.position, Quaternion.identity);
                Obj.transform.parent = player.transform;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameObject.tag == "Camera")
            {
              //  Debug.Log("aaaa");
                Obj = (GameObject)Instantiate(item[2], this.transform.position, Quaternion.identity);
                Obj.transform.parent = player.transform;
            }
        }
    }
}
