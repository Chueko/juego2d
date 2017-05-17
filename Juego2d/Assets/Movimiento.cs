using UnityEngine;
using System.Collections;

public class Movimiento : MonoBehaviour {
	public float speed = 4f;
	public Rigidbody2D rigBod;

	// Use this for initialization
	void Start () {
		rigBod = GetComponent<Rigidbody2D> ();

	}

	// Update is called once per frame
	void Update () {
		rigBod.velocity = new Vector2 (-1 * speed, rigBod.velocity.y);

		float srand;
		srand = (Random.value);
		srand = srand * 2;
		if ((srand - 1) < 0.5f) {
			if (rigBod.position.y < -3) {
				rigBod.AddForce (new Vector2 (0, (150f * srand)));
			}
		}


	}
}