using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlennCtrl : MonoBehaviour {
    Rigidbody2D glennRB;
    SpriteRenderer glennRenderer;
    Animator glennAnim;

    public float maxSpeed;
    private bool facingRight;

    // Use this for initialization
    void Start () {
        glennRB = GetComponent<Rigidbody2D>();
        glennRenderer = GetComponent<SpriteRenderer>();
        glennAnim = GetComponent<Animator>();
        facingRight = true;
	}
	
	// Glenn moves right and left, can shoot weapon
	void Update () {
        float move = Input.GetAxis("Horizontal");

        glennAnim.SetFloat("MoveSpeed", Mathf.Abs(move));
        if (move < 0 == facingRight) {
            Turn();
        }
        glennRB.velocity = new Vector2(move * maxSpeed, glennRB.velocity.y);
	}

    //Switch directions
    void Turn () {
        facingRight = !facingRight;
        glennRenderer.flipX = !glennRenderer.flipX;
    }
}
