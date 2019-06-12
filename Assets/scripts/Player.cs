using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D rb;
	public DisplayData displaydata;


	public bool isGrounded, canJump;
	public float jump;
	private RaycastHit2D collider;
	public LayerMask groundLayer;
	public Transform groundCheck;
	private Animator anim;
	// Use this for initialization
	void Start () {
		isGrounded = false;
		rb = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate() {
		checkGround ();
		if (displaydata.GetBlinkValue () > 75)
			canJump = true;
		else
			canJump = false;
		
		if (isGrounded && canJump) {
			rb.AddForce (new Vector2 (transform.position.x, jump), ForceMode2D.Impulse);
			canJump = false;
		}

		if (displaydata.GetAttetionValue () > 70) {
			anim.SetBool ("walk", true);
		} else {
			anim.SetBool ("walk", false);
		}
	}

	void checkGround () {
		this.collider = Physics2D.Linecast (transform.position, groundCheck.position, groundLayer);
		if (this.collider.collider != null) {
			isGrounded = true;
		} else {
			isGrounded = false;
		}
	}
}
