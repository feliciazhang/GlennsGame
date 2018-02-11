using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlennCtrl : MonoBehaviour {
    private bool facingRight;
    private int health;

    public Rigidbody2D glennRB;
    public SpriteRenderer glennRenderer;
    public Animator glennAnim;
    public float maxSpeed;

    // Use this for initialization
    void Start () {
        glennRB = GetComponent<Rigidbody2D>();
        glennRenderer = GetComponent<SpriteRenderer>();
        glennAnim = GetComponent<Animator>();
        facingRight = true;
        health = 50;
	}
	
	// Glenn moves right and left, can shoot weapon
	void Update () {
        float move = Input.GetAxis("Horizontal");

        //move
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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // gain health when pizza eaten
        if(collider.gameObject.tag == "pizza") {
            health = health < 99 ? health + 2 : 100;
        }
        if(collider.gameObject.tag == "edge") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
