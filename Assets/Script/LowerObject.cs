using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    //声明刚体组件
    public EscQuit pause;
    private float speed = 0.1f;
    private bool isOnFloor = true;
    public GameObject upperFloor;
    public GameObject lowerFloor;
    Rigidbody2D rigidbody;
    //力大小
    public float force;
    void Start()
    {
        //获取刚体组件
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!pause.isPause)
        {
            transform.Translate(Vector2.right * speed);
            //
            if (Input.GetMouseButtonDown(1) && isOnFloor)
            {
                Jump();
                isOnFloor = false;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.gravityScale = -rigidbody.gravityScale;
                force = -force;
                isOnFloor = false;
            }
        }
        

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 现更新为Tilemap地板
        if (collision.gameObject == upperFloor)
        {
            isOnFloor = true;
        }
        if (collision.gameObject == lowerFloor)
        {
            isOnFloor = true;
        }
    }

    void Jump()
    {
        //对物体施加方向向上的力，也可以对rigidbody.velocity进行操作，但是不推荐
        rigidbody.AddForce(Vector2.up * force);
    }
}