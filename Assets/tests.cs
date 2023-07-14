using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tests : MonoBehaviour
{
    float timer = 0;
    int counter = 0;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(testCoroutine());
    }
    IEnumerator testCoroutine()
    {
        Debug.Log("1‰ñ–Ú");
        timer += Time.deltaTime;
        counter++;
        yield return new WaitForSeconds(2f);
        Debug.Log("2‰ñ–Ú");
    }
}
