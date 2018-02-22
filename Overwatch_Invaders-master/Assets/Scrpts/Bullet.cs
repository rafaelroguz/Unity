using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public int puntosGanados = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D c){
		if (c.tag.CompareTo ("Enemy") == 0) {
			/*Animator animacion = c.gameObject.GetComponent<Animator> ();
			animacion.SetBool ("murio", true);*/
			NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
			Debug.Log ("EnemigoDetectado");
			c.gameObject.SetActive (false);
			Destroy (c.gameObject);
			this.gameObject.SetActive (false);

		}
	}


}
