using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorusB : MonoBehaviour {
	
	public int size;
	GameObject otherGameObject;
	public Text scoreUI;
	public Text win;
	private int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		score += 1;
		scoreUI.text = score.ToString ();
		if (score == 7) {
			win.text = "GANASTE";
		}
	}
		
	void OnMouseDrag(){
		float distanceToScreen = Camera.main.WorldToScreenPoint (gameObject.transform.position).z;
		transform.position = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, distanceToScreen));
	}

	//void OnTriggerEnter(Collider c){
	//	if (c.gameObject.CompareTag ("Cilindro")) {
	//		score += 1;
	//		scoreUI.text = score.ToString ();
	//		if (score == 7) {
	//			win.text = "Lo lograste con el mínimo de movimientos";
	//		}
	//	}


	//}

}
