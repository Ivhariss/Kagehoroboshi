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
    [SerializeField] private Item item;
    [SerializeField]private Slot slot;
    [SerializeField] private ItemList itemList;
    [SerializeField] private Transform toolPos;
    // Start is called before the first frame update
    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerAction = new PlayerAction();
        playerAction.Enable();
        rb = this.GetComponent<Rigidbody>();
        lockButton = playerAction.FindAction("CameraLock");
    }

    //カメラの向いてる方向を正面として移動させる
    private void FixedUpdate()
    {
        if (lockButton.IsPressed())
        {
            isCameraLocked = true;
        }
        else isCameraLocked = false;
        PlayerMove();
    }

    //プレイヤーの移動
    void PlayerMove()
    {
        //入力情報取得
        Vector3 controlDir = new Vector3 (playerAction.Player.Move.ReadValue<Vector2>().x,0, playerAction.Player.Move.ReadValue<Vector2>().y);
        //カメラの方向（XZ）を単位ベクトル化
        Vector3 cameraDir = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1));
        //移動方向の決定
        Vector3 moveDir = cameraDir * controlDir.z + Camera.main.transform.right * controlDir.x;
        rb.velocity = moveDir * playerMoveSpeed + new Vector3(0, rb.velocity.y, 0);
        if (playerAction.Player.Move.IsPressed() == true)
        {
            animator.SetBool("Walking", true);
        }
        else animator.SetBool("Walking", false);
        //振り向き
        if (moveDir != Vector3.zero && isCameraLocked == false)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(moveDir), timeToDir * Time.deltaTime);
        }
        else if(moveDir !=  Vector3.zero && isCameraLocked == true)
        {
            transform.rotation = Quaternion.LookRotation(cameraDir);
        }
 
    }


    //アイテム拾う処理
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            LightStatus lightStatus = other.GetComponent<LightStatus>();
            textMeshPro.text = "PickUp";
            //この後に拾う入力を受け取り、手持ちの道具リストに入れる
           if(playerAction.Player.PickUp.WasPressedThisFrame() == true)
            {
                //ここに拾っているアイテム番号を入れる(Slotのアイテムスプライト配列番号参照)
                switch(other.gameObject.name)
                {
                    case "HandLight":
                        slot.SetItem(1);
                        other.gameObject.SetActive(false);
                        textMeshPro.text = string.Empty;
                        itemList.InstantiateItem(1);
                        break;
                    default:
                        slot.SetItem(0);
                        itemList.InstantiateItem(0);
                        break;
                }
                
               

                
                lightStatus.isPicked = true;
                
            }
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
