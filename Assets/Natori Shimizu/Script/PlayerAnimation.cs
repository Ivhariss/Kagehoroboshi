using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;
    private bool _walk = false;
    private bool _hasLighter = true;
    private bool _hasFlashLight = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Anim();
    }

    public void Anim()
    {
        if (_hasLighter)
        {
            anim.SetBool("IdleHasLighter", true);
            anim.SetBool("IdleHasFlashLight", false);
        }
        else if (_hasFlashLight)
        {
            anim.SetBool("IdleHasFlashLight", true);
            anim.SetBool("IdleHasLighter", false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("E");
            if (_hasLighter)
            {
                _hasLighter = false;
                _hasFlashLight = true;
            }
            else if (_hasFlashLight)
            {
                _hasFlashLight = false;
                _hasLighter = true;
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            Walk();
            if (_walk)
            {
                if (_hasLighter)
                {
                    anim.SetBool("IdleHasLighter", false);
                    anim.SetBool("walkHasLighter", true);
                }
                else if (_hasFlashLight)
                {
                    anim.SetBool("IdleHasFlashLight", false);
                    anim.SetBool("walkHasFlashLight", true);
                }
            }

        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Stop();
            if (_walk == false)
            {
                if (_hasLighter)
                {
                    anim.SetBool("IdleHasLighter", true);
                    anim.SetBool("walkHasLighter", false);
                }
                else if (_hasFlashLight)
                {
                    anim.SetBool("IdleHasFlashLight", true);
                    anim.SetBool("walkHasFlashLight", false);
                }
            }
        }
    }
    public void Walk()
    {
        Debug.Log("Down");
        _walk = true;
    }
    public void Stop()
    {
        Debug.Log("Up");
        _walk = false;
    }
}
