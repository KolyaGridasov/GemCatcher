using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
	public GameObject Tree;
	private float[] RandomPositions = new float[18];
	float timer = 6f;


	void Start()
	{
		System.Random rnd = new System.Random();
		for (int i = 0; i < RandomPositions.Length; i++)
		{
			RandomPositions[i] = rnd.Next(-8, 8);
		}
		StartCoroutine(spawnTrees());
		
	}
	IEnumerator spawnTrees()
	{
		while (true)
		{
			Instantiate(Tree, new Vector3(RandomPositions[UnityEngine.Random.Range(0, RandomPositions.Length)], -8f, 0), Quaternion.identity);
			yield return new WaitForSeconds(timer);
		}
	}
}
