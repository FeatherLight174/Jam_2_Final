using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialEnd : MonoBehaviour
{
    bool m_End = false;
    public GameObject player;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            m_End = true;
        }
    }
    void FixedUpdate()
    {
        if (m_End)
        {
            SceneManager.LoadScene(2);
        }
    }
}
