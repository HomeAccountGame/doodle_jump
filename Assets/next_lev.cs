using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class next_lev : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(next());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator next()
    {
        GetComponent<TextMeshPro>().text = "Mooving to the \r\nnext level!!\n3";
        yield return new WaitForSeconds(1f);
        GetComponent<TextMeshPro>().text = "Mooving to the \r\nnext level!!\n2";
        yield return new WaitForSeconds(1f);
        GetComponent<TextMeshPro>().text = "Mooving to the \r\nnext level!!\n1";
        yield return new WaitForSeconds(1f);
        Debug.Log("click");
        string level = PlayerPrefs.GetString("myString");
        Debug.Log(level);

        SceneManager.LoadScene(level);
    }
}
