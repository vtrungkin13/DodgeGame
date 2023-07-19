using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveFalling : MonoBehaviour
{
    
    public float speedMultiplier = 2f;

    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 15;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        speed += speedMultiplier * Time.deltaTime;
    }
}
