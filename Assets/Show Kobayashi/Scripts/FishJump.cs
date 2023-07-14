using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishJump : MonoBehaviour
{
    [SerializeField] float initialSpeed = 10f;
    public void  JumpFish(Vector3 targetPos)
    {
        // ターゲットへの方向ベクトルを計算
        Vector3 direction = (targetPos - transform.position).normalized;

        // 初速度ベクトルを計算
        Vector3 initialVelocity = direction * initialSpeed;

        // 初速度ベクトルの水平成分を設定
        this.GetComponent<Rigidbody>().velocity = new Vector3(initialVelocity.x, 0f, initialVelocity.z);

        // 初速度ベクトルの垂直成分を設定
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * initialVelocity.y, ForceMode.VelocityChange);
    }
}
