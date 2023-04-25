using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attact : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    public int damageAmount = 20; // Damage amount of the ball
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Method to handle the collision with the monster
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        // Check if the collided game object is a monster
        if (collision.gameObject.name.StartsWith("Circle"))
        {
            Debug.Log("hit the ball");
            // Get the monster script component of the monster game object
            kill monster = collision.gameObject.GetComponent<kill>();

            // Call the TakeDamage method of the monster script component
            monster.TakeDamage(damageAmount);

            // Destroy the ball game object
            Destroy(collision.gameObject);
        }
    }*/
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);

        if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}
