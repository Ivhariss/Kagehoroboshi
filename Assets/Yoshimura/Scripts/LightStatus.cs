using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class LightStatus : MonoBehaviour
{ 
    
    public static LightStatus instance;

    [SerializeField]
    public float LightHP; //�A�C�e���̑ϋv�l
   // public bool isPicked = false;
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

    /*void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("aaa");
        ItemBox.instance.SetItem(item);


        if (Input.GetKeyUp(KeyCode.F) && collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("www");
            
        }
    }*/


}
