using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorTrigger : MonoBehaviour
{
    public GameObject blueObject;
    public GameObject redObject;
    public GameObject blueFloor;
    public GameObject redFloor;
    public MissTime missTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collider2D other)
    {   
        if(((other.gameObject == blueFloor)&&(gameObject == redObject))|| ((other.gameObject == redFloor) && (gameObject == blueObject)))
        {
            missTime.miss++;
            Debug.Log(missTime.miss);
        }

    }
}
