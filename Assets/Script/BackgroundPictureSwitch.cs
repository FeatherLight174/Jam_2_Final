using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundPictureSwitch : MonoBehaviour
{
    public GameObject picture1;
    public GameObject picture2;
    public GameObject picture3;
    public GameObject picture4;
    public GameObject switchPoint;
    private int num = 0;
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
        if (other.gameObject == switchPoint)
        {
            num = (num + 1) / 4;
        }
    }
}
