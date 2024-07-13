using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTrigger : MonoBehaviour
{
    public GameObject blueObject;
    public GameObject redObject;
    public GameObject blueObstacle;
    public GameObject redObstacle;
    public GameObject greenObstacle;
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
        if ((other.gameObject == blueObstacle)|| (other.gameObject == redObstacle)||((other.gameObject == greenObstacle)&&(gameObject == blueObject)))
        {
            missTime.miss++;
        }

    }
}
