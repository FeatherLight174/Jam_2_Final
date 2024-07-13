using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSwitch : MonoBehaviour
{
    public GameObject upDownSwitch;
    public GameObject background;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == upDownSwitch)
        {
            background.transform.Rotate(0f, 0f, gameObject.transform.rotation.eulerAngles.z + 180f, Space.Self);
        }
    }
}
