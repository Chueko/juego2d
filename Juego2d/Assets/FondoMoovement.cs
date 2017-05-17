using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMoovement : MonoBehaviour {
	public float speed = 4f;
	public Rigidbody2D rigBod;

	// Use this for initialization
	void Start () {
		rigBod = GetComponent<Rigidbody2D> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		rigBod.velocity = new Vector2 (-1 * speed, rigBod.velocity.y);
		if (rigBod.position.x < -33f) {
			rigBod.position = new Vector2 (48.9f, rigBod.velocity.y);
		}
		
		
	}
}