using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeScript : MonoBehaviour
{
    public Player playerr;
    public Button Pause;
    public Button Resume;
    private AudioSource[] AllAudioSources;


    public void Unpause()
    {
        Pause.gameObject.SetActive(true);
        Resume.gameObject.SetActive(false);
        Time.timeScale = playerr.timer;
        
        foreach (AudioSource Audio in AllAudioSources)
        {
            Audio.Stop();
            Audio.enabled = false;
        }
    }
}
