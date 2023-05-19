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

    private void Damage()
    {
        if(PlayerHP >= 0)
        {
            //PlayerHP - [] = PlayerHP; 
        }
        else if(PlayerHP <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Damage();
    }
}
