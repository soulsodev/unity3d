using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject friendPrefab;
    // Start is called before the first frame update
    void Start()
    {
        generatePrefabs(enemyPrefab, friendPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void generatePrefabs(GameObject enemyPrefab, GameObject friendPrefab)
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5f, 5f), 1, Random.Range(-10f, 10f));
            Instantiate(enemyPrefab, position, Quaternion.identity);
        }

        for (int i = 0; i < 5; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5f, 5f), 1, Random.Range(-10f, 10f));
            Instantiate(friendPrefab, position, Quaternion.identity);
        }
    }
}
