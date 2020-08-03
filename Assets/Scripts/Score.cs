using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public static int scoreAmount;
	private Text scoreText;

	 void Start()
	{
		scoreText = GetComponent<Text>();
		scoreAmount = 0;
	}

	 void Update()
	{

		if (scoreAmount > PlayerPrefs.GetInt("HighScore", 0))
		{
			PlayerPrefs.SetInt("HighScore", scoreAmount);
			PlayerPrefs.Save();
		}
		scoreText.text = "Score: " + scoreAmount;

		
	}
}
