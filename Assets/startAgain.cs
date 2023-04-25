using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startAgain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("click");
        string level = PlayerPrefs.GetString("myString");
        Debug.Log(level);

        SceneManager.LoadScene(level);
    }
}
