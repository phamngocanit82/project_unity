using UnityEngine;
using System.Collections;

public class SpiderCave_SpiderJumper : MonoBehaviour {
	public float forceY = 300f;
	private Rigidbody2D myBody;
	private Animator anim;

	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}
	void Start () {
		StartCoroutine (Attack ());
	}
	IEnumerator Attack(){
		yield return new WaitForSeconds (Random.Range (2, 7));

		forceY = Random.Range (350f, 600f);

		myBody.AddForce (new Vector2 (0, forceY));

		anim.SetBool ("Attack", true);

		yield return new WaitForSeconds (.7f);

		StartCoroutine (Attack ());

	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Player") {
			GameObject.Find("Gameplay Controller").GetComponent<SpiderCave_GameplayController>().PlayerDied();
			Destroy(target.gameObject);
		}

		if (target.tag == "Ground") {
			anim.SetBool("Attack",false);
		}
	}
	void Update () {

	}
}
