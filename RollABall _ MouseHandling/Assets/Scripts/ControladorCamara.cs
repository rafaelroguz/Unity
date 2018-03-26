using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour {

	public GameObject esfera;
	private Vector3 desplazamiento;

	// Use this for initialization
	void Start () {
		desplazamiento = transform.position - esfera.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = esfera.transform.position + desplazamiento;
	}
}
