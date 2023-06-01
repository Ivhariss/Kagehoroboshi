using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField]
    private int PlayerHP;
    //[SerializeField]
    //private float MoveSpeed;
    // Start is called before the first frame update

    private void OncollisionEnter3D(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("aaa");
            Damage();
        }
    }
    private void Damage()
    {
        if(PlayerHP >= 0)
        {
            PlayerHP -= 10;
        }
        else if(PlayerHP == 0)
        {
            Destroy(this.gameObject);
        }
    }


}
