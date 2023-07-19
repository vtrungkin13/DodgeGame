using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Our enemy to spawn
    public Transform enemy;

    public float speedUpTime = 5f;

    private float timeElapsed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        float spawnTime = 0.3f;
        float posY = 11.5f;
        while(true)
        {
            timeElapsed += Time.deltaTime;
            if (spawnTime > 0.5 && timeElapsed >= speedUpTime)
            {
                spawnTime -= 0.5f;
                speedUpTime += speedUpTime;
            }
            float posX = Random.Range(-4.6f, 4.6f);
            Instantiate(enemy, new Vector3(posX, posY, 0), this.transform.rotation);
            yield return new WaitForSeconds(spawnTime);
        }
    }


}