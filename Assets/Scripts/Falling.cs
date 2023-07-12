using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float speedUpTime = 2f;

    private float timeElapsed = 0f;

    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (speed < 10 && timeElapsed >= speedUpTime)
        {
            speed++;
            speedUpTime += speedUpTime;
        }
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
