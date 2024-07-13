using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleObject : MonoBehaviour
{
    public GameObject invisibleObstacle;
    public GameObject blueObject;
    public MissTime missTime;
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
        if ((other.gameObject == invisibleObstacle) || (gameObject == blueObject))
        {
            missTime.miss++;
        }

    }

}
