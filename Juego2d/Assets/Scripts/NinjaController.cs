using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour {
	public Rigidbody2D rigBod;
	public float maxSpeed= 10f;
	Animator anim;
	public float jumpForce = 400f;
	public float jumpForceD = -400f;
	bool doubleJump=false;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask groundIs;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		rigBod = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {

		jumpForce = 400f;

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, groundIs);
		anim.SetBool ("Ground", grounded);
		if (grounded)
			doubleJump = false;
		anim.SetFloat ("vSpeed", rigBod.velocity.y);

		if ((grounded || !doubleJump) && Input.GetKeyDown (KeyCode.Space)) {
			anim.SetBool ("Ground", false);
			if(anim.GetFloat("vSpeed") < 0)
				rigBod.AddForce (new Vector2 (0, (-1.5f * jumpForceD)));
			else
				rigBod.AddForce (new Vector2 (0, (jumpForce - 10f)));

			if (!doubleJump && !grounded) {
				doubleJump = true;
			}
		}


		float move = Input.GetAxis ("Horizontal");
		anim.SetFloat ("Speed", Mathf.Abs (move));
		rigBod.velocity = new Vector2 (move * maxSpeed, rigBod.velocity.y);

	}

}
