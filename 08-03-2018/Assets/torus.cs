using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torus : MonoBehaviour {

    GameObject otherGameObject;
    int size;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        otherGameObject = collision.gameObject;
        print("(" + size + ")" + "Detected collision betwen " + gameObject.name + " and " + collision.collider.name);        
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Size=" + size);
        print(gameObject + " and " + collision.collider.name + " are no longer colliding");
    }
}
