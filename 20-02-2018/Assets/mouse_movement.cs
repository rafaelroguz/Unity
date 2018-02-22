using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_movement : MonoBehaviour {

    public Vector2 mousePosition;
    public float moveSpeed = 0.1f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButton(1))
        {
            mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
        }
	}
}
