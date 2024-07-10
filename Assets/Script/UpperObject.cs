using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperObject : MonoBehaviour
{
    //声明刚体组件
    public EscQuit pause;
    private float speed = 0.1f;
    private bool isOnFloor = true;
    public GameObject floor;
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
            if (Input.GetMouseButtonDown(0) && isOnFloor)
            {
                Jump();
                isOnFloor = false;
            }
        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == floor)
        {
            isOnFloor = true;
        }
    }

    void Jump()
    {
        //对物体施加方向向上的力，也可以对rigidbody.velocity进行操作，但是不推荐
        rigidbody.AddForce(Vector2.down * force);
    }
}