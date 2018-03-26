using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoA : MonoBehaviour {

    private Renderer rend;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Debug.Log("Diste un clic");
    }

    private void OnMouseUp()
    {
        Debug.Log("Liberaste el clic");
    }

    private void OnMouseEnter()
    {
        rend.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        rend.material.color = Color.white;
    }

    private void OnMouseOver()
    {
        rend.material.color -= new Color(0.1f, 0.1f, 0) * Time.deltaTime;
        rb.AddForce(transform.forward * 100f);
    }
}
