using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollider : MonoBehaviour
{
    public GameObject ignoreCollider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BoxCollider2D myCollider = GetComponent<BoxCollider2D>();
        BoxCollider2D otherCollider = ignoreCollider.GetComponent<BoxCollider2D>();

        if (myCollider != null && otherCollider != null)
        {
            Physics2D.IgnoreCollision(myCollider, otherCollider);
        }
    }
}
