using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStatus : MonoBehaviour
{
    public static LightStatus instance;

    [SerializeField]
   public float LightHP = 0; //�A�C�e���̑ϋv�l

    private float flashTime;

    //Object�ɂ��Ă�light
    public GameObject flashLight;

     void Start()
    {
        flashLight.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        flashItem();
     }


  public void flashItem()
    {
        if(LightHP >= 1) 
        {

            LightHP -= Time.deltaTime;
               
        }


        if (1 >= LightHP)
        {
            flashLight.SetActive(false);
        }

    }


}
