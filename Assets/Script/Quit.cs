using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public bool started = false;
    bool stateAlreadyChanged = false;
    void Update()
    {
        if (Input.GetAxis("Submit") == 1 && stateAlreadyChanged == false)
        {
            started = true;
            Debug.Log("Started");
            stateAlreadyChanged = true;
        }
        if (Input.GetAxis("Submit") == 0)
        {
            stateAlreadyChanged = false;
        }
        if (started)
        {
            Application.Quit();
        }
    }
}
