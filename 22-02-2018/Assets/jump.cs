using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    public Rigidbody2D frogg;
    public int jumpForce;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            frogg.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

	}
}
