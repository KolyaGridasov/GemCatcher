using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public Player player;
    public Button Pause;
    public Button Resume;
    private AudioSource AS;


    public void PauseGame()
	{
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
            Pause.gameObject.SetActive(false);
            Resume.gameObject.SetActive(true);
            AS.enabled = true;
            AS.Play();
        }
    }
 
}
