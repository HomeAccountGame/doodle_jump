using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f; // Speed of the platform
    public float distance = 7f; // Distance the platform will move

    private Vector2 startPosition;

    private void Start()
    {
        speed = Random.Range(1.5f, 2.5f);
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        // Move the platform horizontally back and forth
        float newPosition = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector2(startPosition.x + newPosition, transform.position.y);
    }
}