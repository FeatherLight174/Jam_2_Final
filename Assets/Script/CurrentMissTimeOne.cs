using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentMissTimeOne : MonoBehaviour
{
    public MissTime missTime;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public GameObject eight;
    public GameObject nine;
    public GameObject zero;
    private int hundred;

    // Start is called before the first frame update
    void Start()
    {
        zero.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);
        four.SetActive(false);
        five.SetActive(false);
        six.SetActive(false);
        seven.SetActive(false);
        eight.SetActive(false);
        nine.SetActive(false);
        zero.SetActive(false);
        hundred = missTime.miss % 10;
        if (hundred == 0)
        {
            zero.SetActive(true);
        }
        if (hundred == 1)
        {
            one.SetActive(true);
        }
        if (hundred == 2)
        {
            two.SetActive(true);
        }
        if (hundred == 3)
        {
            three.SetActive(true);
        }
        if (hundred == 4)
        {
            four.SetActive(true);
        }
        if (hundred == 5)
        {
            five.SetActive(true);
        }
        if (hundred == 6)
        {
            six.SetActive(true);
        }
        if (hundred == 7)
        {
            seven.SetActive(true);
        }
        if (hundred == 8)
        {
            eight.SetActive(true);
        }
        if (hundred == 9)
        {
            nine.SetActive(true);
        }
    }