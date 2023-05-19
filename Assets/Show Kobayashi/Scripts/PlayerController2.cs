using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private float playerMoveSpeed = 1.0f;
    private Rigidbody rb;
    private PlayerAction playerAction;
    [SerializeField] private float timeToDir = 0;
    private Animator animator;
    [SerializeField]private TextMeshProUGUI textMeshPro;
    private GameObject lightItem;
   [SerializeField] private bool isCameraLocked = false;
    private InputAction lockButton;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerAction = new PlayerAction();
        playerAction.Enable();
        rb = this.GetComponent<Rigidbody>();
        lockButton = playerAction.FindAction("CameraLock");
    }

    //�J�����̌����Ă�����𐳖ʂƂ��Ĉړ�������
    private void FixedUpdate()
    {
        if (lockButton.IsPressed())
        {
            isCameraLocked = true;
        }
        else isCameraLocked = false;
        PlayerMove();
    }

    //�v���C���[�̈ړ�
    void PlayerMove()
    {
        //���͏��擾
        Vector3 controlDir = new Vector3 (playerAction.Player.Move.ReadValue<Vector2>().x,0, playerAction.Player.Move.ReadValue<Vector2>().y);
        //�J�����̕����iXZ�j��P�ʃx�N�g����
        Vector3 cameraDir = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1));
        //�ړ������̌���
        Vector3 moveDir = cameraDir * controlDir.z + Camera.main.transform.right * controlDir.x;
        rb.velocity = moveDir * playerMoveSpeed + new Vector3(0, rb.velocity.y, 0);
        if (playerAction.Player.Move.IsPressed() == true)
        {
            animator.SetBool("Walking", true);
        }
        else animator.SetBool("Walking", false);
        //�U�����
        if (moveDir != Vector3.zero && isCameraLocked == false)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), timeToDir * Time.deltaTime);
        }
        else if(moveDir !=  Vector3.zero && isCameraLocked == true)
        {
            transform.rotation = Quaternion.LookRotation(cameraDir);
        }
 
    }


    //�A�C�e���E������
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Item")
        {
            textMeshPro.text = "PickUp";
            //���̌�ɏE�����͂��󂯎��A�莝���̓���X�g�ɓ����
           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            textMeshPro.text = string.Empty;
        }

        
    }
}
