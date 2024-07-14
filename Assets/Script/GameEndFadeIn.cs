using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndFadeIn : MonoBehaviour
{
    float m_Timer = 0;
    public CanvasGroup winCanvasGroup;
    public float fadeTime;
    void Update()
    {
        m_Timer += Time.deltaTime;
        winCanvasGroup.alpha = Mathf.Max(1 - m_Timer / fadeTime, 0);
    }
}
