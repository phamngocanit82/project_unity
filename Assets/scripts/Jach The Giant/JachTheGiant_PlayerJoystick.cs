using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JachTheGiant_PlayerJoystick : MonoBehaviour {
	public float speed = 8f;
	public float maxVelocity = 4f; 

	private Rigidbody2D myBody2D;
	private Animator anim;
	private bool moveLeft, moveRight;
	void Awake(){
		myBody2D = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (moveLeft) {
			MoveLeft ();
		}
		if (moveRight) {
			MoveRight ();
		}
	}
	public void SetMove(bool moveLeft){
		this.moveLeft = moveLeft;
		this.moveRight = !moveLeft;
	}
	public void StopMove(){
		this.moveLeft = this.moveRight = false;
		anim.SetBool ("FlagWalk", false);
	}
	void MoveLeft(){
		float forceX = 0f;
		float velocity = Mathf.Abs(myBody2D.velocity.x);
		if(velocity < maxVelocity)
			forceX = -speed;
		anim.SetBool ("FlagWalk", true);
		Vector3 vector3 = transform.localScale;
		vector3.x = -1f;
		transform.localScale = vector3;
		myBody2D.AddForce (new Vector2 (forceX,0));
	}
	void MoveRight(){
		float forceX = 0f;
		float velocity = Mathf.Abs(myBody2D.velocity.x);
		if(velocity < maxVelocity)
			forceX = speed;
		anim.SetBool ("FlagWalk", true);
		Vector3 vector3 = transform.localScale;
		vector3.x = 1f;
		transform.localScale = vector3;
		myBody2D.AddForce (new Vector2 (forceX,0));
	}
}
