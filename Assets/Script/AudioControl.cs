using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    AudioSource player;
    public EscQuit pause;

    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.isPause)
        {
            player.Pause();
        }
        else
        {
            player.UnPause();
        }
        if (player.isPlaying)
        {
        }
    }
}
