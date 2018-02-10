using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlennCtrl : MonoBehaviour {
    Rigidbody2D glennRB;
    SpriteRenderer glennRenderer;

    bool facingRight;
    
	// Use this for initialization
	void Start () {
        glennRB = GetComponent<Rigidbody2D>();
        glennRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis("Horizontal");
        if(move < 0 == facingRight) {
            Turn();
        }
	}

    //Switch directions
    void Turn () {

    }
}
