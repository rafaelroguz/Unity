using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleCollission : MonoBehaviour {

    public GameObject frogg;
    public GameObject bubble;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        frogg.transform.SetParent(bubble.transform);
    }
}
