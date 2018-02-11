using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour {
    public GlennCtrl glenn;
    public bool isFollowing;
    public float xOffset;
    public float yOffset;

	// Use this for initialization
	void Start () {
        glenn = FindObjectOfType<GlennCtrl>();
        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if(isFollowing) {
            transform.position = new Vector3(glenn.transform.position.x + xOffset,
                glenn.transform.position.y + yOffset, glenn.transform.position.z);
        }
		
	}
}
