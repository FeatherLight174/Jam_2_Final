using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperObject : MonoBehaviour
{
    //�����������
    public EscQuit pause;
    private float speed = 0.1f;
    private bool isOnFloor = true;
    public GameObject floor;
    Rigidbody2D rigidbody;
    //����С
    public float force;
    void Start()
    {
        //��ȡ�������
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
        //������ʩ�ӷ������ϵ�����Ҳ���Զ�rigidbody.velocity���в��������ǲ��Ƽ�
        rigidbody.AddForce(Vector2.down * force);
    }
}