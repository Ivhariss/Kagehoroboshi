using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Text text;

    private const int _threshold = 30;
    private int _duration = 0;

    public enum MyState
    {
        Normal,
        Attack
    }

    // Start is called before the first frame update
    void Start()
    {
        text.enabled = false;
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");

        foreach(GameObject item in items)
        {
            Debug.Log(item.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        const float Speed = 0.1f;
        float x = Input.GetAxis("Horizontal2");
        float y = Input.GetAxis("Vertical2");
        gameObject.transform.position += new Vector3(x*Speed, 0, y*Speed);
    }

    public void SetState(MyState normal)
    {

    }

    void OnCollisionStay(Collision other)
    {
        Debug.Log("ni");
        if (other.gameObject.CompareTag("Item"))
        {
            Debug.Log("wa");
            text.enabled = true;

            if (Input.GetAxisRaw("Circle") == 1)
            {
                text.enabled = false;
                _duration++;
                if (_duration == _threshold)
                {
                    Debug.Log("yu");
                }
            }
            if (Input.GetAxisRaw("Circle") == 0)
            {
                _duration = 0;
            }
        }
    }
}
