using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarryDwightCtrl : MonoBehaviour {
    Rigidbody2D barryRB;

    private bool movingUp;
    private float speed;
    private Transform destPoint;
    public Transform[] points;
    private int health;

    public int pointSelection;

	// Use this for initialization
	void Start () {
        barryRB = GetComponent<Rigidbody2D>();
        destPoint = points[pointSelection];
        speed = Random.Range(4.0f, 10.0f);
        health = 100;
    }
	
	// Barry Dwight moves up and down at random speed
	void Update () {
        barryRB.transform.position = Vector3.MoveTowards(barryRB.transform.position,
            destPoint.position, Time.deltaTime * speed);
        if (barryRB.transform.position == destPoint.position) {
            pointSelection = pointSelection == points.Length - 1 ? 0 : pointSelection + 1;
            destPoint = points[pointSelection];
            speed = Random.Range(4.0f, 10.0f);
        }
        //die when no health
        if(health <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // gain health when pizza eaten
        if (collision.gameObject.tag == "pizza")
        {
            health -= 10;
        }
    }
}
