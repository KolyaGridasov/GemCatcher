using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            double halfScreen = Screen.width / 2.0;

            if (touchPosition.x < halfScreen)
            {
                player.transform.rotation = Quaternion.Euler(0, 0, 0);

                player.transform.Translate(Vector3.left * 6 * Time.deltaTime / 2);
            }
            else if (touchPosition.x > halfScreen)
            {
                player.transform.rotation = Quaternion.Euler(0, 180f, 0);

                player.transform.Translate(Vector3.left * 6 * Time.deltaTime / 2);
            }

        }
    }
}
