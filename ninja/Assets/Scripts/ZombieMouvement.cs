using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMouvement : MonoBehaviour
{
    public float speed = 100f;
    float scaleX;
    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * transform.localScale.x;
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed * transform.localScale.x;
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "weapon")
        {
            Destroy(gameObject);
        }
    }
}
