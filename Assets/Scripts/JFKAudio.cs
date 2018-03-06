using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class JFKAudio : MonoBehaviour {

	public BarryDwightCtrl barry;
	public AudioSource audio;

	private bool playing;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
		playing = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (!playing && barry.health <= 0) {
			playing = true;
			audio.Play ();
			audio.Play (44100);
			Debug.Log ("jfk");
		}
	}
}
