using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorusHandler : MonoBehaviour {
	public MovementManager movManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		movManager.addPointsToScore (1);
	}

	void OnMouseDrag(){
		float distanceToScreen = Camera.main.WorldToScreenPoint (gameObject.transform.position).z;
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToScreen));
	}
}
