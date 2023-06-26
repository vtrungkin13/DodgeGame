using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveSpawn : MonoBehaviour
{
    public Transform objectToSpawn;
    public float minSpawnInterval = 60f;
    public float maxSpawnInterval = 120f;

    private float spawnTimer = 0f;
    private float nextSpawnTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = GetNextSpawnTime();
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;

        if (spawnTimer >= nextSpawnTime)
        {
            SpawnObject();
            nextSpawnTime = GetNextSpawnTime();
            spawnTimer = 0f;
        }
    }

    float GetNextSpawnTime()
    {
        return Random.Range(minSpawnInterval, maxSpawnInterval);
    }

    void SpawnObject()
    {
        float posX = Random.Range(-4.6f, 4.6f);
        float posY = 11.5f;

        Instantiate(objectToSpawn, new Vector3(posX, posY), this.transform.rotation);
        Debug.Log(nextSpawnTime);
    }
}
