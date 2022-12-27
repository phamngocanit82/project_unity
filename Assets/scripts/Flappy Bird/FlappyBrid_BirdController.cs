using UnityEngine;
using System.Collections;

public class FlappyBrid_BirdController : MonoBehaviour {
	public static FlappyBrid_BirdController instance;
	public float bounceForce;
	private Rigidbody2D myBody;
	private Animator anim;
	[SerializeField]
	private AudioSource audioSource;
	[SerializeField]
	private AudioClip flyClip,pingClip,diedClip;
	private bool isAlive;
	private bool didFlap;
	private GameObject spawner;
	public float flag=0;
	public int score=0;
	void Awake () {
		isAlive = true;
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		_MakeInstance ();
		spawner = GameObject.Find ("Spawner Pipe");
	}
	void _MakeInstance(){
		if (instance == null) {
			instance = this;
		}
	}
	void FixedUpdate () {
		_BirdMovement ();
	}

	void _BirdMovement(){
		if (isAlive) {
			if (didFlap) {
				didFlap = false;
				myBody.velocity = new Vector2 (myBody.velocity.x, bounceForce);
				audioSource.PlayOneShot (flyClip);
			}
		}
		if (myBody.velocity.y > 0) {
			float angel = 0;
			angel = Mathf.Lerp (0, 90, myBody.velocity.y / 7);
			transform.rotation = Quaternion.Euler (0, 0, angel);
		}else if (myBody.velocity.y == 0) {
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}else if (myBody.velocity.y < 0) {
			float angel = 0;
			angel = Mathf.Lerp (0, -90, -myBody.velocity.y / 7);
			transform.rotation = Quaternion.Euler (0, 0, angel);
		}
	}
	public void FlapButton(){
		didFlap = true;
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "PipeHolder") {
			score++;
			if (FlappyBrid_GamePlayController.instance != null) {
				FlappyBrid_GamePlayController.instance._SetScore (score);
			}
			audioSource.PlayOneShot (pingClip);
		}
	}
	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Pipe" || target.gameObject.tag == "Ground") {
			flag = 1;
			if (isAlive) {
				isAlive = false;
				Destroy (spawner);
				audioSource.PlayOneShot (diedClip);
				anim.SetTrigger ("Died");
			}
			if (FlappyBrid_GamePlayController.instance != null) {
				FlappyBrid_GamePlayController.instance._BirdDiedShowPanel (score);
			}
		}
	}
}
