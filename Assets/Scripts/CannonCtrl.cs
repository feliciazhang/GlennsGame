using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCtrl : MonoBehaviour {
    public GameObject weapon;
    public Transform fire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Fire weapon of choice when clicked
	void Update () {
        if(Input.GetButtonDown("Fire1")) {
            FireWeapon();
        }
	}

    void FireWeapon() {
        Instantiate(weapon, fire.transform.position, fire.transform.rotation);
    }
}
