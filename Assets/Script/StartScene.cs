using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public GameObject QuitButton;
    public GameObject ResumeButton;
    // Start is called before the first frame update
    void Start()
    {
        QuitButton.SetActive(true);
        ResumeButton.SetActive(true);
    }
    public void QuitEvent()
    {
        Application.Quit();
    }
    public void ResumeEvent()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
