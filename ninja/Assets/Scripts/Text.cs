using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour {
    public GameObject Message;

	// Use this for initialization
	void Start () {
        Destroy(Message, 4f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
