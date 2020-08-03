using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    float speed = 2f;
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
        if (transform.position.y > 8f)
        {
            Destroy(gameObject);
        }
    }

}
