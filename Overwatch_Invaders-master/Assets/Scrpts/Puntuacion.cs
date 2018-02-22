using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {

	private int puntuacion = 0;
	public Text marcador;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		ActualizarMarcador();
	}

	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;

		puntuacion+=puntosAIncrementar;
		ActualizarMarcador();
	}

	void ActualizarMarcador(){
		marcador.text = puntuacion.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
