using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraItem : MonoBehaviour
{
    //à»â∫2Ç¬ïKê{
    public GameObject slight;
    float SpotAngle;

    [SerializeField]
    float flashtime;
    [SerializeField]
    float flash;
    [SerializeField]
    public static int flashCount;

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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(WaitProcess());
        }
    }

    IEnumerator WaitProcess()
    {
        while (SpotAngle < 100f)
        {
            SpotAngle += flash;
            slight.GetComponent<Light>().spotAngle = SpotAngle;

            // éwíËÇµÇΩïbêîÇæÇØèàóùÇë“ÇøÇ‹Ç∑ÅB(Ç±Ç±Ç≈ÇÕ1.0ïb)
            yield return new WaitForSeconds(flashtime);
        }

        while (0 < SpotAngle)
        {
            SpotAngle -= flash;
            slight.GetComponent<Light>().spotAngle = SpotAngle;

        }
    }
}
