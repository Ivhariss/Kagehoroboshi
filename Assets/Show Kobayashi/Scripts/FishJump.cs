using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishJump : MonoBehaviour
{
    [SerializeField] float initialSpeed = 10f;
    public void  JumpFish(Vector3 targetPos)
    {
        // �^�[�Q�b�g�ւ̕����x�N�g�����v�Z
        Vector3 direction = (targetPos - transform.position).normalized;

        // �����x�x�N�g�����v�Z
        Vector3 initialVelocity = direction * initialSpeed;

        // �����x�x�N�g���̐���������ݒ�
        this.GetComponent<Rigidbody>().velocity = new Vector3(initialVelocity.x, 0f, initialVelocity.z);

        // �����x�x�N�g���̐���������ݒ�
        this.GetComponent<Rigidbody>().AddForce(Vector3.up * initialVelocity.y, ForceMode.VelocityChange);
    }
}
