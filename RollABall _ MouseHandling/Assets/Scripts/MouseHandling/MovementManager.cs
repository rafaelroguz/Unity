using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementManager : MonoBehaviour {
	public Text scoreText;
	private int score;
	public Text win;


	// Use this for initialization
	void Start () {
		score = 0;
		StartCoroutine (UpdateScoreText ());
		
	}

	private IEnumerator UpdateScoreText(){
		while (true) {
			scoreText.text = score.ToString ();
			yield return new WaitForSeconds (0.5f);
		} yield return new WaitForSeconds (0.5f);
	}

	public void addPointsToScore(int points){
		score += points;
	}


	// Update is called once per frame
	void Update () {
		
	}
}
