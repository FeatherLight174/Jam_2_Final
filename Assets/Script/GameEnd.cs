using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    bool m_End = false;
    float m_Timer = 0;
    public GameObject player;
    public float loadTime;
    public CanvasGroup winCanvasGroup;
    public float fadeTime;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            m_End = true;
        }
    }
    void Update()
    {
        if (m_End)
        {
            m_Timer += Time.deltaTime;
        }
        if (m_Timer > loadTime)
        {
            winCanvasGroup.alpha = Mathf.Min((m_Timer - loadTime) / fadeTime, 1);
        }
        if (m_Timer > loadTime + fadeTime)
        {
            SceneManager.LoadScene(3);
        }
    }
}
