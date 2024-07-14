using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPauseTrigger : MonoBehaviour
{
    public int FJSpace;
    public GameObject F;
    public GameObject J;
    public GameObject Space;
    public EscQuit pause;
    public GameObject redPlayer;
    public GameObject bluePlayer;
    public LowerObject red;
    public UpperObject blue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        if (pause.isPause)
        {
            if ((Input.GetKeyDown(KeyCode.F)) && (FJSpace == 0))
            {
                pause.isPause = false;
                bluePlayer.GetComponent<Rigidbody2D>().velocity = new Vector2(0, blue.jumpSpeed);

            }
            else if ((Input.GetKeyDown(KeyCode.J)) && (FJSpace == 1))
            {
                pause.isPause = false;
                redPlayer.GetComponent<Rigidbody2D>().velocity = new Vector2(0, red.jumpSpeed);
            }
            else if ((Input.GetKeyDown(KeyCode.Space)) && (FJSpace == 2))
            {
                pause.isPause = false;
                bluePlayer.GetComponent<Rigidbody2D>().gravityScale = -bluePlayer.GetComponent<Rigidbody2D>().gravityScale;
                redPlayer.GetComponent<Rigidbody2D>().gravityScale = -redPlayer.GetComponent<Rigidbody2D>().gravityScale;
                blue.jumpSpeed = -blue.jumpSpeed;
                red.jumpSpeed = -red.jumpSpeed;

            }
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
        if (!pause.isPause)
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

            if (!pause.isPause)
            {

                pause.isPause = true;
                Time.timeScale = 0.0f;

            }
        }
    }
}
