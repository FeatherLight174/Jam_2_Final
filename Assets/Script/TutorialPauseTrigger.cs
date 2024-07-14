using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPauseTrigger : MonoBehaviour
{
    public GameObject pauseTrigger;
    public int FJSpace;
    public string key;
    private bool isPause = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F))||FJSpace == 0)
        {
            isPause = false;
        }
        if ((Input.GetKeyDown(KeyCode.J)) || FJSpace == 1)
        {
            isPause = false;
        }
        if ((Input.GetKeyDown(KeyCode.Space)) || FJSpace == 2)
        {
            isPause = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other == pauseTrigger)
        {
            if (!isPause)
            {
                isPause = true;
                Time.timeScale = 0.0f;
            }
        }
    }
}
