using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    [SerializeField]
    public GameObject OnPanel_1;
    [SerializeField]
    public GameObject OnPanel_2;
    [SerializeField]
    public GameObject OnPanel_3;
    [SerializeField]
    public GameObject OnPanel_4;
    [SerializeField]
    public GameObject OnPanel_5;
    public Button _retry;
    public Button _toTitle;
    public Button _lightCtrl;
    public Button _explain;
    public Button _resume;
    public Button _yes1;
    public Button _yes2;
    public Button _back1;
    public Button _back2;
    public Button _back3;
    public Button _back4;
    private bool pauseGame = false;

    // Start is called before the first frame update
    void Start()
    {
        OnUnPause();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("L1") == 1 || Input.GetKeyDown(KeyCode.Space))
        {
            pauseGame = !pauseGame;

            if (pauseGame == true)
            {
                OnPause();
            }
            else
            {
                OnUnPause();
            }
        }
    }

    public void OnPause()
    {
        OnPanel_1.SetActive(true);
        OnPanel_2.SetActive(false);
        OnPanel_3.SetActive(false);
        OnPanel_4.SetActive(false);
        OnPanel_5.SetActive(false);
        _retry.Select();
        Time.timeScale = 0;
        pauseGame = true;
    }

    public void OnUnPause()
    {
        OnPanel_1.SetActive(false);
        OnPanel_2.SetActive(false);
        OnPanel_3.SetActive(false);
        OnPanel_4.SetActive(false);
        OnPanel_5.SetActive(false);
        Time.timeScale = 1;
        pauseGame = false;

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void OnResumeButton()
    {
        OnUnPause();
    }

    public void OnRetryButton()
    {
        OnPanel_1.SetActive(false);
        OnPanel_2.SetActive(true);
        _back1.Select();
    }

    public void OnToTitleButton()
    {
        OnPanel_1.SetActive(false);
        OnPanel_3.SetActive(true);
        _back2.Select();
    }

    public void OnLightCtrl()
    {
        OnPanel_1.SetActive(false);
        OnPanel_4.SetActive(true);
        _back3.Select();
    }

    public void OnExpalinButton()
    {
        OnPanel_1.SetActive(false);
        OnPanel_5.SetActive(true);
        _back4.Select();
    }

    public void OnRetryYes()
    {
        SceneManager.LoadScene("MainGame");
    }

    public void OnToTitleYes()
    {
        SceneManager.LoadScene("Start");
    }

    public void OnBack()
    {
        OnPause();
    }
}
