using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class UpperObjectAutoJump : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float force;
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
        if ((int)koreographyEvent.GetIntValue() == 1)
        {
            rigidbody.AddForce(Vector2.down * force);
        }
        if ((int)koreographyEvent.GetIntValue() == 2)
        {
            rigidbody.gravityScale = -rigidbody.gravityScale;
            force = -force;
        }

        
    }
}
