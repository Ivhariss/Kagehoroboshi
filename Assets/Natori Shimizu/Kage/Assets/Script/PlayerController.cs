using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum MyState
    {
        Normal,
        Attack
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Holizontal");
        float z = Input.GetAxis("Vertical");
    }

    public void SetState()
    {

    }
}
