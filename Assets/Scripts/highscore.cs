using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
	private Text _highScore;
	void Start()
	{
		Time.timeScale = 1;
		_highScore = GetComponent<Text>();

	}
        void Update()
	{

		_highScore.text = "" + PlayerPrefs.GetInt("HighScore", 0);
	}
}
