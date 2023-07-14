using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraItem : MonoBehaviour
{
    //以下2つ必須
    public GameObject slight;
    float SpotAngle;

    [SerializeField]
    float flashtime;
    [SerializeField]
    float flash;
    [SerializeField]
    public int flashCount;

    // Use this for initialization
    void Start()
    {
        SpotAngle = slight.GetComponent<Light>().spotAngle;
        SpotAngle = 0f;
        slight.GetComponent<Light>().spotAngle = SpotAngle;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && flashCount >0)
        {
            StartCoroutine(WaitProcess());
            flashCount--;
        }
    }

    IEnumerator WaitProcess()
    {
        while (SpotAngle < 100f)
        {
            SpotAngle += flash;
            slight.GetComponent<Light>().spotAngle = SpotAngle;

            // 指定した秒数だけ処理を待ちます。(ここでは1.0秒)
            yield return new WaitForSeconds(flashtime);
        }

        while (0 < SpotAngle)
        {
            SpotAngle -= flash;
            slight.GetComponent<Light>().spotAngle = SpotAngle;

        }
    }
}
