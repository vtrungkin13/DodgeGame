using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{

    private float moveHoz;
    private float moveVer;
    private float speed = 10f;
    private float xMin = -4.6f;
    private float xMax = 4.6f;
    private float yMin = -8.9f;
    private float yMax = 8.9f;
    private int lives = 3;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        MouseMoving();
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), transform.position.y, transform.position.z);       
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax), transform.position.z);
    }

    void MouseMoving()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPosition;
    }

    void KeyboardMoving()
    {
        moveHoz = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveHoz, 0) * speed * Time.deltaTime;

        moveVer = Input.GetAxis("Vertical");
        transform.position += new Vector3(0, moveVer) * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("enemy"))
        {
            Destroy(collision.gameObject);
            lives--;
        }
    } 
}
