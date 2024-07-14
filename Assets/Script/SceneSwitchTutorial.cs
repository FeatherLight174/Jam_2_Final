using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitchTutorial : MonoBehaviour
{
    public string tutorial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Enter))
        {
            SceneManager.LoadScene(tutorial, LoadSceneMode.Single);
        }
    }
}
