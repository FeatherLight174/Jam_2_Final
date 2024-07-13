using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class LowerObjectAutoJump : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float jumpSpeed;
    public EscQuit pause;
    public string eventID;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Koreographer.Instance.RegisterForEvents(eventID, AutoJump);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AutoJump(KoreographyEvent koreographyEvent)
    {


        if ((int)koreographyEvent.GetIntValue() == 0)
        {
            rigidbody.velocity = new Vector2(0, jumpSpeed);
            print("0:");
            Debug.Log(gameObject.transform.position.x);
        }
        if ((int)koreographyEvent.GetIntValue() == 2)
        {
            rigidbody.gravityScale = -rigidbody.gravityScale;
            jumpSpeed = -jumpSpeed;
            print("2:");
            Debug.Log(gameObject.transform.position.x);
        }
    }

}

