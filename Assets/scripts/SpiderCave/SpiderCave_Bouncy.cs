using UnityEngine;
using System.Collections;

public class SpiderCave_Bouncy : MonoBehaviour {

	public float force = 500f;

	private Animator anim;

	void Awake(){
		anim = GetComponent<Animator>();
	}
	IEnumerator AnimateBouncy(){
		anim.Play("Up");
		yield return new WaitForSeconds(.5f);
		anim.Play("Down");
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Player") {
			target.gameObject.GetComponent<SpiderCave_PlayerScript>().BouncePlayerWithBouncy(force);
			StartCoroutine(AnimateBouncy());
		}
	}
}
