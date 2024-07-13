using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public GameObject reversePoint;
    public GameObject upperBackground;
    public GameObject lowerBackground;
    public float upperBY;
    public float lowerBY;
    public float x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == reversePoint)
        {
            upperBY = upperBackground.transform.position.y;
            lowerBY = lowerBackground.transform.position.y;
            x = upperBackground.transform.position.x;
            upperBackground.GetComponent<Transform>().position = new Vector2(x, lowerBY);
            lowerBackground.GetComponent<Transform>().position = new Vector2(x, upperBY);

        }

    }
}
