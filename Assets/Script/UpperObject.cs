using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperObject : MonoBehaviour
{
    //�����������
    public EscQuit pause;
    // ע��speed����Ҫ��һ���ƶ����룬һ��30��λ
    public float speed = 0.1f;
    private bool isOnFloor = true;
    public GameObject upperFloor;
    public GameObject lowerFloor;
    Rigidbody2D rigidbody;
    //����С
    public float jumpSpeed;

    void Start()
    {
        //��ȡ�������
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!pause.isPause)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            //
            if (Input.GetKeyDown(KeyCode.F))
            {
                Jump();
                isOnFloor = false;
            }
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.gravityScale = -rigidbody.gravityScale;
                jumpSpeed = -jumpSpeed;
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
        rigidbody.velocity = new Vector2(0, jumpSpeed);
    }
}