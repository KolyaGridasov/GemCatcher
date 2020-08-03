using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 6f;

	void FixedUpdate()
	{
		if (transform.position.y > 1.8f)
		{
			transform.Translate(Vector3.down * speed * Time.deltaTime);

		}
	}
}
