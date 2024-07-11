using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
