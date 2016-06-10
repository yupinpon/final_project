using UnityEngine;
using System.Collections;

public class SoundControl : MonoBehaviour {
	
	public AudioSource BGSong;
	public AudioSource DeathSong;
	public AudioSource TrueSong;
	public AudioSource FalseSong;
	public AudioSource BoomSong;

	public static int itemCheckSound = 0;
	public static bool boomCheck = false;


	void FixedUpdate () {
		BGSong.mute = true;

	
	}
}
