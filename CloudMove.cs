using UnityEngine;

public class CloudMove : MonoBehaviour //done
{
    public float speed = 1.5f;
    public float leftLimit = -15f;
    public float rightStart = 15f;

    void Update()
    {
        // Move cloud to the left
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // If cloud goes out of screen, move it back
        if (transform.position.x < leftLimit)
        {
            transform.position = new Vector3(
                rightStart,
                transform.position.y,
                transform.position.z
            );
        }
    }
}