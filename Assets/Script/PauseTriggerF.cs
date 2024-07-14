using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTriggerF : MonoBehaviour
{
    public GameObject F;
    public EscQuit pause;
    public GameObject redPlayer;
    public GameObject bluePlayer;
    public LowerObject red;
    public UpperObject blue;
    private bool isF = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pause.isPause)
        {
            if ((Input.GetKeyDown(KeyCode.F))&&isF)
            {
                pause.isPause = false;
                bluePlayer.GetComponent<Rigidbody2D>().velocity = new Vector2(0, blue.jumpSpeed);
            }
            F.GetComponent<Animation>().Play();
        }
        if (!pause.isPause)
        {
            Time.timeScale = 1.0f;
            isF = false;
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
                    isF = true;
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
                isF = true;
                pause.isPause = true;
                Time.timeScale = 0.0f;

            }
        }
    }
}