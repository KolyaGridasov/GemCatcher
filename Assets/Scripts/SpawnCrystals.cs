using System.Collections;

using UnityEngine;

public class SpawnCrystals : MonoBehaviour
{
	public GameObject coin;
	float timerCrystals = 5.5f;
	//public GameObject dead;
	private float[] positions = { -7.5f,-6.5f,-5.5f,-4.5f,-3.5f,-2.5f,-1.5f,-0.5f,0.5f,1.5f,2.5f,3.5f,4.5f,5.5f,6.5f,7.5f };

	void Start()
    {
        StartCoroutine(spawn());
    }
	
	IEnumerator spawn()
	{
		while (true)
		{
			Instantiate(coin, new Vector3(positions[Random.Range(0, positions.Length)], -6f, 0), Quaternion.identity);
			yield return new WaitForSeconds(timerCrystals);
		}
	}

}
