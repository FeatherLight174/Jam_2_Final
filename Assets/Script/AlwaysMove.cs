using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysMove : MonoBehaviour
{
    public EscQuit pause;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause.isPause)
        {
            transform.Translate(Vector2.right * speed);
        }
    }
}
