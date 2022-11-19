﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseScript : MonoBehaviour {
    public GameObject ninja;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ninja)
        {
            if (collision.gameObject.tag == "Zombie")
                ninja.GetComponent<ninjamouvement>().health--;
        }
    }
}