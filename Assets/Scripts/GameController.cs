using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Our enemy to spawn
    public Transform enemy;
    // We want to delay our code at certain times
    public float delayTime = 1.5f;
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", delayTime);
        InvokeRepeating("SpawnEnemies", delayTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        float posX = Random.Range(-4.6f, 4.6f);
        float posY = 11.5f;

        Instantiate(enemy, new Vector3(posX, posY, 0), this.transform.rotation);

    }

}