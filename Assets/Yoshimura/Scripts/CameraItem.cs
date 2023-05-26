using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraItem : MonoBehaviour
{
    private int flashCount = 3;

    public GameObject flash;

    void Start()
    {
        flash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Space)&& flashCount > 0)
        {
            flashCount--;

            flash.SetActive(true);

          //  StartCoroutine(DelayCoroutine());
        }
       
        if(flashCount == 0)
        {
            this.gameObject.SetActive(false);
        }
      
    }

    /*private IEnumerator DelayCoroutine()
    {
        flash.SetActive(false);

        // 3•bŠÔ‘Ò‚Â
        yield return new WaitForSeconds(1);

        
    }
    */
}
