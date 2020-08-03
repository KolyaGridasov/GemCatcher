using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed = 6f;
    AudioSource audioData;
    public Button Restart;
    public Button Pause;
    public Button Resume;

    public float timer;
    
    void Start()
    {

		Restart.gameObject.SetActive(false);
        Resume.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
	void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        Vector3 dir = new Vector3(hor, 0, 0);
        Vector3 dirn = new Vector3(-hor, 0, 0);
        if (Input.GetKey("left"))
		{
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(dir.normalized * (Time.deltaTime / 2 ) * speed);
        }
        if (Input.GetKey("right"))
        {
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            transform.Translate(dirn * (Time.deltaTime / 2)  * speed);
        }
    }
    private void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.CompareTag("Crystal"))
        {
            Score.scoreAmount += 1;
            if (Score.scoreAmount % 5 == 0)
            {
                Time.timeScale += 0.3f;
                timer = Time.timeScale;
            }
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);

        }
        if (collision.gameObject.CompareTag("Dead"))
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
            PauseGame();
        }
    }
    void PauseGame()
    {
        AudioSource audioData1 = GameObject.Find("PauseButton").GetComponent<AudioSource>();

        audioData1.Stop();
        Pause.gameObject.SetActive(false);
        Restart.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
