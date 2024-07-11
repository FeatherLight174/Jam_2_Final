using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    public GameObject upperObject;
    public GameObject lowerObject;
    public HeartPoint hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if((other.gameObject == upperObject)||(other.gameObject == lowerObject))
        {
            hp.heartPoint--;
        }

    }
}
