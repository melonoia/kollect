using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    
	public static AudioManager instance;

	public Sound[] sounds;

	void Start ()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		} else
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.loop = s.loop;
		}
	}

	public void Play (string sound)
	{
	if(GameManager.mute)
		return;
		Sound s = Array.Find(sounds, item => item.name == sound);
		s.source.Play();
		
		if(!MenuManager.sounds)
		{
			s.source.Stop();
		}
	
	}

}

	[System.Serializable]
	public class Sound {

	public string name;

	public AudioClip clip;

	[Range(0f, 1f)]
	public float volume;

	public bool loop = false;

	[HideInInspector]
	public AudioSource source;

}

