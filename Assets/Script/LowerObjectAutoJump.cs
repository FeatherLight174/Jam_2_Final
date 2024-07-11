using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class LowerObjectAutoJump : MonoBehaviour
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
        rigidbody.AddForce(Vector2.up * force);
    }
}
