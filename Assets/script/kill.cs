using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    int life = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("player"))
        {
            string myString = SceneManager.GetActiveScene().name; // the string you want to pass to the next scene
            SceneManager.LoadScene("gameOver", LoadSceneMode.Single);
            PlayerPrefs.SetString("myString", myString);
        }
    }
    public void TakeDamage(int damage)
    {
        life -= damage;
        Debug.Log("die");

        Destroy(gameObject);
        //Destroy(self);
    }
}
