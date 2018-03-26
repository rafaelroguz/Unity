using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour {

    public int score = 0;
    public Text restartTEXT;
    public Text GameOverTEXT;
    private bool restart, gameover;

	// Use this for initialization
	void Start () {
        restart = false;
        gameover = false;
        restartTEXT.text = "";
        GameOverTEXT.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("scene2");
            print("Tecla R");
        }

        if (gameover)
        {
            restartTEXT.text = "Presiona la tecla <R> para jugar nuevamente";
            restart = true;
        }
	}

    public void GameOver()
    {
        GameOverTEXT.text = "Game Over";
        gameover = true;
    }
}
