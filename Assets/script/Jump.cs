using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float jumpForce;
    void Start()
    {
        if (jumpForce <= 0f) jumpForce = 800f;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0 && collision.gameObject.name.StartsWith( "player"))
        {

            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpForce);

        }

    }
}
