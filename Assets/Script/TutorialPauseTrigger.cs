using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPauseTrigger : MonoBehaviour
{
    public int FJSpace;
    public GameObject F;
    public GameObject J;
    public GameObject Space;
    private bool isPause = true;
    public GameObject pauseTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)) && FJSpace == 0)
        {
            isPause = false;
        }
        if ((Input.GetKeyDown(KeyCode.J)) && FJSpace == 1)
        {
            isPause = false;
        }
        if ((Input.GetKeyDown(KeyCode.Space)) && FJSpace == 2)
        {
            isPause = false;
        }
        if (isPause)
        {
            if (FJSpace == 0)
            {
                F.GetComponent<Animation>().Play();
            }
            if (FJSpace == 1)
            {
                J.GetComponent<Animation>().Play();
            }
            if (FJSpace == 2)
            {
                Space.GetComponent<Animation>().Play();
            }
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
