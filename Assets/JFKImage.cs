using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JFKImage : MonoBehaviour {

	public SpriteRenderer jfk;
	public BarryDwightCtrl barry;

	// Use this for initialization
	void Start () {
		jfk.GetComponent<SpriteRenderer> ();
		GetComponent<SpriteRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (barry.health <= 0) {
			jfk.enabled = true;
		}
	}
}
