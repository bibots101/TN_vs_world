using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ninjamouvement : MonoBehaviour
{
    public GameObject RIP;
    public int health;
    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    Rigidbody2D rb2d;
    public bool isRunning;
    public bool isJumping;
    public float speed = 10f;
    float scaleX;
    void Start()
    {
        scaleX = transform.localScale.x;
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        if (h > 0)
        {
            transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
            GetComponent<Animator>().SetBool("isRunning", true);
        }
            if (h < 0)
            {
                transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
            GetComponent<Animator>().SetBool("isRunning", true);
        }

            if (h == 0)
            {
                GetComponent<Animator>().SetBool("isRunning", false);
            }

                GetComponent<Rigidbody2D>().velocity = new Vector2(h * speed, GetComponent<Rigidbody2D>().velocity.y);

        }
    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;

        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (health == 0)
        {
            SceneManager.LoadScene(2);
          
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Zombie")
            health--;
    }
}