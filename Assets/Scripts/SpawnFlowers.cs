using System.Collections;
using System;
using UnityEngine;

public class SpawnFlowers : MonoBehaviour
{
	public GameObject flower;
	public GameObject[] others;
	float timer = 1.9f;
	float timerOther = 3.5f;
	private float[] positions = { -7.5f, -6.5f, -5.5f, -4.5f, -3.5f, -2.5f, -1.5f, -0.5f, 0.5f, 1.5f, 2.5f, 3.5f, 4.5f, 5.5f, 6.5f, 7.5f };
	private float[] RandomPositions = new float [18];

	void Start()
	{
		System.Random rnd = new System.Random();
		for (int i=0;i<RandomPositions.Length;i++)
		{
			RandomPositions[i] = rnd.Next(-8,8) ;
		}
		StartCoroutine(spawnFlowers());
		StartCoroutine(spawnOthers());
	}
	IEnumerator spawnFlowers()///
	{
		while (true)
		{
			Instantiate(flower, new Vector3(positions[UnityEngine.Random.Range(0, positions.Length)], -6f, 0), Quaternion.identity);
			yield return new WaitForSeconds(timer);		
		}
	}
	IEnumerator spawnOthers()
	{
		while (true)
		{
			Instantiate(others[UnityEngine.Random.Range(0, others.Length)], new Vector3(RandomPositions[UnityEngine.Random.Range(0, RandomPositions.Length)], -6f, 0), Quaternion.Euler(0,180f,0));
			yield return new WaitForSeconds(timerOther);
		}
	}

}
