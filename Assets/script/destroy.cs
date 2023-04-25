using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject platformPrefabMove;
    public GameObject TramploinPrefab;

    public GameObject myPlat;
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
        if (collision.gameObject.name.StartsWith("platformPrefabMove"))
        {
            myPlat = (GameObject)Instantiate(platformPrefabMove, new Vector2(Random.Range(-10.5f, 10.5f), player.transform.position.y + (20 + Random.Range(0.1f, 1.0f))), Quaternion.identity);
        }
        else if (collision.gameObject.name.StartsWith("platform") || collision.gameObject.name.StartsWith("Tramp"))
        {
            int randomNumber = UnityEngine.Random.Range(1, 9);
            Debug.Log(randomNumber);
            if (randomNumber == 5)
            {
                myPlat = (GameObject)Instantiate(TramploinPrefab, new Vector2(Random.Range(-10.5f, 10.5f), player.transform.position.y + (20 + Random.Range(0.1f, 1.0f))), Quaternion.identity);
            }
            else
            {
                myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-10.5f, 10.5f), player.transform.position.y + (20 + Random.Range(0.1f, 1.0f))), Quaternion.identity);

            }
        }
        Destroy(collision.gameObject);


    }
}
