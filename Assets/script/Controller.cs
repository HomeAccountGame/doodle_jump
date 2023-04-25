using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Controller : MonoBehaviour
{
    [SerializeField] scoreUpdate scoreField;
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 10f;
    private float score;

    void Start()
    {
        score = 0;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (transform.position.y > score)
        {
            score = transform.position.y;
            if (score > 500f && SceneManager.GetActiveScene().name == "level1")
            {
                string nextLevel = "level2"; // the string you want to pass to the next scene
                SceneManager.LoadScene("next_level", LoadSceneMode.Single);
                PlayerPrefs.SetString("myString", nextLevel);
            }
            if (score > 1000f && SceneManager.GetActiveScene().name == "level2")
            {
                string nextLevel = "level3"; // the string you want to pass to the next scene
                SceneManager.LoadScene("next_level", LoadSceneMode.Single);
                PlayerPrefs.SetString("myString", nextLevel);
            }
        }
        scoreField.AddNumber(score);
        if(transform.position.y < score - 50)
        {
            string myString = SceneManager.GetActiveScene().name; // the string you want to pass to the next scene
            SceneManager.LoadScene("gameOver", LoadSceneMode.Single);
            PlayerPrefs.SetString("myString", myString);

        }
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);
    }

    public void SetScoreField(scoreUpdate newTextField)
    {
        this.scoreField = newTextField;
    }
}
