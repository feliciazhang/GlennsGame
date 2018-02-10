using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarryDwightCtrl : MonoBehaviour {
    Rigidbody2D barryRB;
    SpriteRenderer barryRenderer;

    private bool movingUp;
    private float speed;
    private Transform destPoint;
    public Transform[] points;
    public int pointSelection;

	// Use this for initialization
	void Start () {
        barryRB = GetComponent<Rigidbody2D>();
        barryRenderer = GetComponent<SpriteRenderer>();
        destPoint = points[pointSelection];
        speed = Random.Range(4.0f, 10.0f);
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
    }
}
