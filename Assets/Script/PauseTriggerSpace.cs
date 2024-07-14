using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTriggerSpace : MonoBehaviour
{
    public GameObject Space;
    public EscQuit pause;
    public GameObject redPlayer;
    public GameObject bluePlayer;
    public LowerObject red;
    public UpperObject blue;
    private bool isSpace;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pause.isPause)
        {
            if ((Input.GetKeyDown(KeyCode.Space))&&isSpace)
            {
                pause.isPause = false;
                /*bluePlayer.GetComponent<Rigidbody2D>().gravityScale = -bluePlayer.GetComponent<Rigidbody2D>().gravityScale;
                redPlayer.GetComponent<Rigidbody2D>().gravityScale = -redPlayer.GetComponent<Rigidbody2D>().gravityScale;
                blue.jumpSpeed = -blue.jumpSpeed;
                red.jumpSpeed = -red.jumpSpeed;*/
            }
        }
        if (!pause.isPause)
        {
            Time.timeScale = 1.0f;
            isSpace = false;
        }
        else
        {
            Time.timeScale = 0.0f;
        }
        void OnTriggerEnter2D(Collider2D other)
        {
            if ((other.gameObject == redPlayer) || (other.gameObject == bluePlayer))
            {

                if (!pause.isPause)
                {
                    isSpace = true;
                    pause.isPause = true;
                    Time.timeScale = 0.0f;

                }
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject == redPlayer) || (other.gameObject == bluePlayer))
        {

            if (!pause.isPause)
            {
                isSpace = true;
                pause.isPause = true;
                Time.timeScale = 0.0f;

            }
        }
    }
}