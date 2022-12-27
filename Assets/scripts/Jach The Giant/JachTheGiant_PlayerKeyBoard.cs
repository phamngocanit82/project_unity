using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JachTheGiant_PlayerKeyBoard : MonoBehaviour {
	public float speed = 8f;
	public float maxVelocity = 4f; 
	public float jump = 50f; 
	private Rigidbody2D myBody2D;
	private Animator anim;
	void Awake(){
		myBody2D = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	void FixedUpdate () {
		PlayerMoveKeyBoard ();
	}
	void PlayerMoveKeyBoard(){
		float forceX = 0f;
		float velocity = Mathf.Abs(myBody2D.velocity.x);
		float h = Input.GetAxisRaw ("Horizontal"); //-1 0 1
		if (h > 0) {
			if (velocity < maxVelocity)
				forceX = speed;
			anim.SetBool ("FlagWalk", true);
			Vector3 vector3 = transform.localScale;
			vector3.x = 1.3f;
			transform.localScale = vector3;

		} else if (h < 0) {
			if(velocity < maxVelocity)
				forceX = -speed;
			anim.SetBool ("FlagWalk", true);
			Vector3 vector3 = transform.localScale;
			vector3.x = -1.3f;
			transform.localScale = vector3;
		}else{
			anim.SetBool ("FlagWalk", false);
		}

		if(Input.GetButtonDown("Jump"))
			myBody2D.AddForce (new Vector2 (forceX,jump));
		else
			myBody2D.AddForce (new Vector2 (forceX,0));
	}
}
