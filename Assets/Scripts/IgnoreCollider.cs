using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class IgnoreCollider : MonoBehaviour
{
    [FormerlySerializedAs("bulletCollider")]
    [SerializeField]
    private Collider2D bulletCollider;

    [FormerlySerializedAs("stoneCollider")]
    [SerializeField]
    private Collider2D stoneCollider;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), bulletCollider);
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), stoneCollider);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
