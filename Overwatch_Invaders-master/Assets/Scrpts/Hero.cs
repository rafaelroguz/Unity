using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hero : MonoBehaviour {
	public int cantidadVidas;
	private int vidasActuales;
	public bool isDeath;
	private float velocityOnX, movementOnX, actualPosition;
	public Rigidbody2D bala;
	public float fuerzaBala;
	private Transform heroe;
	private Animator deathAnimator;
	public Text vidasText;
	private AudioSource audioshoot;
	public SpriteRenderer spriteOver;



	// Use this for initialization
	void Start () {

		vidasActuales = cantidadVidas;
		deathAnimator = this.GetComponent<Animator> ();
		audioshoot = this.GetComponent<AudioSource> ();
		spriteOver.gameObject.SetActive (false);
		velocityOnX = 0.1f;
		movementOnX = actualPosition = 0; 

		heroe = this.transform;
		
	}



	void OnTriggerEnter2D(Collider2D c){
		if (c.tag.CompareTo ("Enemy") == 0) {
			vidasActuales = vidasActuales - 1;
			Debug.Log ("Dañado" + vidasActuales);
			audioshoot.Play ();
			if(vidasActuales <0)
				isDeath = true;
		}
	}


	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis ("Horizontal");
		if (isDeath == false) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				shoot ();
			}
			if (inputX != 0)
				movimientoHorizontal (inputX);
			//audio = this.GetComponent<AudioSource> ();
			Debug.Log ("" + vidasActuales.ToString () + " / " + cantidadVidas.ToString ());

			vidasText.text = "" + vidasActuales.ToString () + " / " + cantidadVidas.ToString ();
		} else {
			spriteOver.gameObject.SetActive (true);
		}

		
	}

	private void shoot(){
		Rigidbody2D bulletInstance = Instantiate (bala, heroe.position , heroe.rotation) as Rigidbody2D;
		bulletInstance.AddForce ( new Vector2(0, fuerzaBala));

	}

	private void movimientoHorizontal(float horizontalMovement){
		movementOnX = transform.position.x + (horizontalMovement * velocityOnX);
		transform.position = new Vector3 (movementOnX, transform.position.y, 0);
		if (horizontalMovement > 0) {
			transform.localScale = new Vector3 (0.7732f,0.7732f,1f);
		} else if (horizontalMovement < 0){
			transform.localScale = new Vector3 (0.7732f,0.7732f,1f);
		}
		movementOnX = actualPosition;
	}
}
