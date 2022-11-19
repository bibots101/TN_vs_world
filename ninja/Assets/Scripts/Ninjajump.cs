using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninjajump : MonoBehaviour
{
    [SerializeField]
    public LayerMask groundLayer;
    public bool isGliding;
    public bool isJumping;
    public float jumpforce = 500f;
    public float speed = 10;
    public bool isTouchingGround;
    void FixedUpdate()
    {
        isTouchingGround = GetComponent<Collider2D>().IsTouchingLayers(groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpforce);
            GetComponent<Animator>().SetBool("isJumping", true);
            GetComponent<Animator>().SetBool("isTouchingGround", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("isJumping", false);
        }
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("isGliding", true);
            GetComponent<Rigidbody2D>().gravityScale = 0.5f;
        }
        else
        {
            GetComponent<Animator>().SetBool("isGliding", false);
            GetComponent<Rigidbody2D>().gravityScale = 3;
       }
    }
    // Update is called once per frame 
    void Update()
    {
    }
}
 