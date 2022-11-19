using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChihebScript : MonoBehaviour {
    public GameObject ninja;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ninja)
        {
            if (collision.gameObject.tag == "ninja")
                ninja.GetComponent<ninjamouvement>().health--;
            Destroy(gameObject);
        }
    }
}