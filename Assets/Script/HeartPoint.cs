using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPoint : MonoBehaviour
{
    public GameOverPanel GameOver;
    public GameObject heartPointRec;
    public int heartPoint = 10;
    private Vector2 obstacleScale;

    // Start is called before the first frame update
    void Start()
    {
        obstacleScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(heartPoint == 0)
        {
            GameOver.GameOver();
        }
        transform.localScale = new Vector2(obstacleScale.x * (heartPoint) / 10, obstacleScale.y);
    }
}
