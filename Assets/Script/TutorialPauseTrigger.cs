using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPauseTrigger : MonoBehaviour
{
    public int FJSpace;
    public GameObject F;
    public GameObject J;
    public GameObject Space;
    private bool isPause = false;
    public GameObject redPlayer;
    public GameObject bluePlayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F)) && (FJSpace == 0))
        {
            isPause = false;
        }
        if ((Input.GetKeyDown(KeyCode.J)) && (FJSpace == 1))
        {
            isPause = false;
        }
        if ((Input.GetKeyDown(KeyCode.Space)) && (FJSpace == 2))
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
        if (!isPause)
        {
            Time.timeScale = 1.0f;
        }
        else
        {
            Time.timeScale = 0.0f;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if((other.gameObject == redPlayer)|| (other.gameObject == bluePlayer))
        {
            Debug.Log(1);
            if (!isPause)
            {
                isPause = true;
                Time.timeScale = 0.0f;

            }
        }
    }
}
