using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D theCollision)
    {
        // this line looks for "laser" in the names of anything collided.
        if (theCollision.gameObject.name.ToUpper().Contains("BULLET"))
        {
            //var bullet = theCollision.gameObject.GetComponent(BulletBehavior) as BulletBehavior;
            var bullet = theCollision.gameObject.GetComponent(typeof(BulletBehavior)) as BulletBehavior;
            health -= bullet.damage;
            Destroy(theCollision.gameObject);
        }

        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
