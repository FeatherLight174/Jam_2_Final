using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTriggerJ : MonoBehaviour
{
    public GameObject J;
    public EscQuit pause;
    public GameObject redPlayer;
    public GameObject bluePlayer;
    public LowerObject red;
    public UpperObject blue;
    private bool isJ;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pause.isPause)
        {
            
            if ((Input.GetKeyDown(KeyCode.J))&&isJ)
            {
                pause.isPause = false;
                redPlayer.GetComponent<Rigidbody2D>().velocity = new Vector2(0, red.jumpSpeed);
            }
        }
        if (!pause.isPause)
        {
            Time.timeScale = 1.0f;
            isJ = false;
        }
        else
        {
            Time.timeScale = 0f;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject == redPlayer) || (other.gameObject == bluePlayer))
        {
            pause.isPause = false;
            if (!pause.isPause)
            {
                isJ = true;
                pause.isPause = true;
                Time.timeScale = 0.0f;

            }
        }
    }
}
