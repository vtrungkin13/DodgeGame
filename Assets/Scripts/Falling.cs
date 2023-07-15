using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public float speedMultiplier = 2f;

    //private float timeElapsed = 0f;

    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        //timeElapsed += Time.deltaTime;
        //if (speed < 15 && timeElapsed >= speedUpTime)
        //{
        //    speed++;
        //    speedUpTime += speedUpTime;
        //}
        //GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * (speed * speedMultiplier);
        
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
        speed += speedMultiplier * Time.deltaTime;
    }
}
