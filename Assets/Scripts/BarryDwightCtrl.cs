using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarryDwightCtrl : MonoBehaviour {
    public Rigidbody2D barryRB;
    public Animator barryAnim;

    private bool movingUp;
    private float speed;
    private Transform destPoint;
    public Transform[] points;
    private int health;

    public int pointSelection;

	// Use this for initialization
	void Start () {
        barryRB = GetComponent<Rigidbody2D>();
        barryAnim = GetComponent<Animator>();
        destPoint = points[pointSelection];
        speed = Random.Range(4.0f, 10.0f);
        health = 100;
    }
	
	// Barry Dwight moves up and down at random speed
	void Update () {
        barryAnim.SetFloat("MoveSpeed", Mathf.Abs(speed));
        barryRB.transform.position = Vector3.MoveTowards(barryRB.transform.position,
            destPoint.position, Time.deltaTime * speed);
        if (barryRB.transform.position == destPoint.position) {
            pointSelection = pointSelection == points.Length - 1 ? 0 : pointSelection + 1;
            destPoint = points[pointSelection];
            speed = Random.Range(4.0f, 10.0f);
        }
        //die when no health
        if(health <= 0) {
            GetComponent<Collider2D>().enabled = false;
            barryRB.gravityScale = 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // lose health when hit by pizza
        if (collider.gameObject.tag == "pizza")
        {
            health -= 10;
        }
    }
}
