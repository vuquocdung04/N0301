using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public GameObject UICenter;
    public Button buttonReplay;
    
    private void Start()
    {
        this.UICenter.gameObject.SetActive(false);

        buttonReplay.onClick.AddListener(this.RePlayGame);
    }

    public void RePlayGame()
    {
        SceneManager.LoadScene(0);
        this.buttonReplay.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }


}
