using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flamingoAudio : MonoBehaviour {
	public BarryDwightCtrl barry;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (barry.health <= 0) {
			audio.Pause ();
		}
	}
}
