using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public SpriteRenderer picture1;
    public SpriteRenderer picture2;
    public SpriteRenderer picture3;
    public SpriteRenderer picture4;
    private float alpha1 = 1f;
    private float alpha2 = 0f;
    private float alpha3 = 0f;
    private float alpha4 = 0f;
    public GameObject switchPoint;
    public GameObject player;
    private int num = 0;
    private float interval = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(num == 0)
        {
            if (alpha1 != 1)
            {
                alpha1 += interval;
            }
            
            if(alpha2 != 0)
            {
                alpha2 -= interval;
            }
            
            if (alpha3 != 0)
            {
                alpha3 -= interval;
            }
            
            if (alpha4 != 0)
            {
                alpha4 -= interval;
            }
            
        }
        if (num == 1)
        {
            if (alpha1 != 0)
            {
                alpha1 -= interval;
            }
            
            if (alpha2 != 1)
            {
                alpha2 += interval;
            }
            if (alpha3 != 0)
            {
                alpha3 -= interval;
            }
            if (alpha4 != 0)
            {
                alpha4 -= interval;
            }
        }
        if (num == 2)
        {
            if (alpha1 != 0)
            {
                alpha1 -= interval;
            }
            
            if (alpha2 != 0)
            {
                alpha2 -= interval;
            }
            if (alpha3 != 1)
            {
                alpha3 += interval;
            }
            if (alpha4 != 0)
            {
                alpha4 -= interval;
            }
        }
        if (num == 3)
        {
            if (alpha1 != 0)
            {
                alpha1 -= interval;
            }
           
            if (alpha2 != 0)
            {
                alpha2 -= interval;
            }
            if (alpha3 != 0)
            {
                alpha3 -= interval;
            }
            if (alpha4 != 1)
            {
                alpha4 += interval;
            }
        }
        picture1.color = new Color(picture1.color.r, picture1.color.g, picture1.color.b, alpha);
        picture2.color = new Color(picture2.color.r, picture2.color.g, picture2.color.b, alpha);
        picture3.color = new Color(picture3.color.r, picture3.color.g, picture3.color.b, alpha);
        picture4.color = new Color(picture4.color.r, picture4.color.g, picture4.color.b, alpha);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == switchPoint)
        {
            num = (num + 1) / 4;
        }
    }
}
