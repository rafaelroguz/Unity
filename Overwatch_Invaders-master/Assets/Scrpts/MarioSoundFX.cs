using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioSoundFX : MonoBehaviour {
	private AudioSource fxSource;
	public AudioClip jumpSound;

	// Use this for initialization
	void Start () {
		fxSource = GetComponent<AudioSource>();
		ClearSource ();
	}

	private void ClearSource(){
		fxSource.clip = null;
	}

	public void PlayMarioJumpFX(){
		ClearSource ();
		fxSource.clip = jumpSound;
		fxSource.Play ();
	}
}
