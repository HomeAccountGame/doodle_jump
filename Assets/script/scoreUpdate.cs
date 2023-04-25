using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshPro))]
public class scoreUpdate : MonoBehaviour
{

    float score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0.0f;
        GetComponent<TextMeshPro>().text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetNumber(float newNumber)
    {
        this.score = newNumber;
           
        GetComponent<TextMeshPro>().text = Mathf.Round(score).ToString();
    }

    public void AddNumber(float toAdd)
    {
        SetNumber(toAdd);
    }
}
