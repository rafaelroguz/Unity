using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float speed;
	public float direccion;
	public float fuerzaBala;
	public Rigidbody2D balaEnemiga;
	public float shootFreq;
	private Transform enemigo;

	// Use this for initialization
	void Start () {
		enemigo = this.transform;
		StartCoroutine (disparar());
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();

	}

	private IEnumerator disparar(){
		while (true) {
			shoot ();
			yield return new WaitForSeconds (shootFreq);
		}yield return new WaitForSeconds (shootFreq);
	}

	private void Movement(){
		transform.Translate (direccion*Vector2.right*speed* Time.deltaTime);
	}
	private void shoot(){
		Rigidbody2D proyectilEnemigo = Instantiate (balaEnemiga, enemigo.position , enemigo.rotation) as Rigidbody2D;
		proyectilEnemigo.AddForce ( new Vector2(0, -fuerzaBala));
	}

	void OnTriggerEnter2D(Collider2D c){
		if(c.tag.CompareTo("Mapa") == 0){
			direccion = (-1) * direccion;
			Debug.Log ("flip");
		}
	}
}
