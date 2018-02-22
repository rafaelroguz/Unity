using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour 
{
	public static MusicManager instance;
	public AudioClip[] levelMusic;
	public float shootFreq;

	private AudioSource audioSource;
	private AudioClip musicBeforeChange;


	void Start()
	{
		instance = this;
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = levelMusic [Random.Range (0, levelMusic.Length)];
		audioSource.Play ();
	}

	public void ChangeMusicToBoss(AudioClip newMusic)
	{
		if (audioSource != null) 
		{
			musicBeforeChange = audioSource.clip;
			audioSource.clip = newMusic;
			audioSource.Play ();
		}
	}

	public void ReturnToNormalMusic()
	{
		if (musicBeforeChange != null) 
		{
			audioSource.clip = musicBeforeChange;
			audioSource.Play ();
		}
	}
}
