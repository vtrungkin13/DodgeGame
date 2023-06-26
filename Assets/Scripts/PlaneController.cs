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

    // The laser we will be shooting
    public Transform laser;

    // How far from the center of the ship should the laser be
    public float laserDistance = .2f;

    // How much time (in seconds) we should wait before we can fire again
    public float timeBetweenFires = .3f;

    // If value is less than or equal 0, we can fire
    private float timeTilNextFire = 0.0f;

    // The buttons that we can use to shoot lasers
    public List<KeyCode> shootButton;

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

        foreach (KeyCode element in shootButton)
        {
            if (Input.GetKey(element) && timeTilNextFire < 0)
            {
                timeTilNextFire = timeBetweenFires;
                ShootLaser();
                break;
            }
        }

        timeTilNextFire -= Time.deltaTime;
    }

    void ShootLaser()
    {
        // calculate the position right in front of the ship's
        // position lazerDistance units away
        var posX = this.transform.position.x +
                     (Mathf.Cos((transform.localEulerAngles.z - 90) * Mathf.Deg2Rad) * -laserDistance);
        var posY = this.transform.position.y + (Mathf.Sin((transform.localEulerAngles.z - 90) * Mathf.Deg2Rad) * -laserDistance);

        Instantiate(laser, new Vector3(posX, posY, 0), this.transform.rotation);
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
}
