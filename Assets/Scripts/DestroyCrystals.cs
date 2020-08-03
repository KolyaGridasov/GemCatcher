using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrystals : MonoBehaviour
{
	private void OnCollisionStay(Collision collision)
	{
		if (collision.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
}
