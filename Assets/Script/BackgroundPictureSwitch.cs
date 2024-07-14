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
    public GameObject player;
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        picture1.SetActive(false); 
        picture2.SetActive(false);
        picture3.SetActive(false);
        picture4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        picture1.SetActive(false);
        picture2.SetActive(false);
        picture3.SetActive(false);
        picture4.SetActive(false);
        if (num == 0)
        {
            picture1.SetActive(true);
            picture2.SetActive(false);
            picture3.SetActive(false);
            picture4.SetActive(false);
        }
        if (num == 1)
        {
            picture1.SetActive(false);
            picture2.SetActive(true);
            picture3.SetActive(false);
            picture4.SetActive(false);
        }
        if (num == 2)
        {
            picture1.SetActive(false);
            picture2.SetActive(false);
            picture3.SetActive(true);
            picture4.SetActive(false);
        }
        if (num == 3)
        {
            picture1.SetActive(false);
            picture2.SetActive(false);
            picture3.SetActive(false);
            picture4.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == switchPoint)
        {
            num = (num + 1) % 4;
        }
    }
}
