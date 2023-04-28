using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightStatus : MonoBehaviour
{
    [SerializeField]
    float LightHP = 0;

    private float flashTime;

    //Object‚É‚Â‚¢‚Ä‚élight
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


   void flashItem()
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
