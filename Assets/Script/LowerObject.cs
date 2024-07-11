using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    //�����������
    public EscQuit pause;
    private float speed = 0.1f;
    private bool isOnFloor = true;
    public GameObject upperFloor;
    public GameObject lowerFloor;
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
        // �ָ���ΪTilemap�ذ�
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
        //������ʩ�ӷ������ϵ�����Ҳ���Զ�rigidbody.velocity���в��������ǲ��Ƽ�
        rigidbody.AddForce(Vector2.up * force);
    }
}